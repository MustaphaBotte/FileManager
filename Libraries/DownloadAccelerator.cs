using System.Diagnostics;
using System.Net.Http.Headers;


namespace FileManager.Libraries
{
    internal class Helpers
    {
        public class DownloadInfo
        {
            public string Path = "";
            public long TotalBytes = 0;
            public bool Support_Range = false;
            public DownloadInfo(string path, long totalBytes, bool support_range)
            {
                Path = path;
                TotalBytes = totalBytes;
                Support_Range = support_range;
            }
            public override string ToString()
            {
                return $"{Path}  {TotalBytes}  , Suppor range{Support_Range}";
            }
        }

        public static async Task<DownloadInfo?> GetDownloadInfo(string FilePath)
        {

            HttpClient httpClient = new HttpClient();
            httpClient.Timeout = new TimeSpan(0, 1, 0);
            try
            {
                var response = await httpClient.GetAsync(FilePath, HttpCompletionOption.ResponseHeadersRead);

                bool acceptsRanges = response.Headers.TryGetValues("Accept-Ranges", out var values)
                         && values.Contains("bytes");


                return new DownloadInfo(FilePath, response.Content.Headers.ContentLength ?? 0, acceptsRanges);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine($"Inner: {ex.InnerException?.Message}");
            }
            return null;
        }
    }
    internal class DownloadAccelerator
    {
        public Action<int> OnDownloadSpeedChanged = delegate { };
        public class Downloader
        {
            private string _FilePath = "";
            private string _SavingPath = "";
            private long _FileSize;
            private Uri uri = null;
            static HttpClient httpClient = new HttpClient();


            string FullSavinPath => Path.Combine(_SavingPath, Path.GetFileName(uri.LocalPath));

            public class Chunk
            {
                public int ChunkIndex;  // thread 0, 1, 2, 3 
                public long BytesDownloaded;
                public long TotalBytes;
                public long StartByte;
                public long EndByte;
                public int RemainingSeconds;
                public double bytesPerSecond = 0;

                public double Percentage => ((double)BytesDownloaded / TotalBytes) * 100;

                public Chunk(int chunkIndex, long startByte, long endByte, long totalBytes, long bytesDownloaded)
                {
                    ChunkIndex = chunkIndex;
                    BytesDownloaded = bytesDownloaded;
                    TotalBytes = totalBytes;
                    StartByte = startByte;
                    EndByte = endByte;
                }

                public override string ToString()
                {
                    return $"[{ChunkIndex}] | {BytesDownloaded}/ bytes | size:{TotalBytes}  PERC:{Percentage:F1}%  Start: {StartByte} | End:{EndByte} | ETA: {RemainingSeconds}m";
                }
            }


            public Downloader(string FilePath, string SavingPath)
            {

                if (!Directory.Exists(SavingPath))
                {
                    throw new Exception("The saving directory does not exists");
                }

                if (!Uri.TryCreate(FilePath, UriKind.Absolute, out Uri? result))
                {
                    throw new Exception("invalid url please try again");
                }
                uri = result;
                _FilePath = FilePath;
                _SavingPath = SavingPath;

            }

            private bool CreateSavingFile()
            {
                try
                {
                    string FileName = Path.GetFileName(uri.LocalPath);
                    string FullSavingPath = Path.Combine(_SavingPath, FileName);
                    using var stream = new FileStream(FullSavingPath, FileMode.Create, FileAccess.Write, FileShare.None);
                    stream.SetLength(this._FileSize); // reserve the space on disk
                    return true;
                }
                catch
                {
                    return false;
                }

            }

            public int RemainingTimeBySeconds(DateTime StartingTime, Chunk chunk)
            {
                double elapsedSeconds = (DateTime.Now - StartingTime).TotalSeconds;

                // If we just started, we can't calculate speed yet
                if (elapsedSeconds < 0.1 || chunk.BytesDownloaded <= 0)
                    return 0;

                // Calculate speed in Bytes per second (more accurate than MB)
                double bytesPerSecond = chunk.BytesDownloaded / elapsedSeconds;

                if (bytesPerSecond <= 0) return 0;


                long bytesRemaining = chunk.TotalBytes - chunk.BytesDownloaded;

                chunk.bytesPerSecond = bytesPerSecond;

                int remaining = (int)(bytesRemaining / bytesPerSecond);


                return remaining ;
            }
            private async Task DownloadAndSaveShunk(Chunk chunk, IProgress<Chunk> CallBack)
            {
                try
                {
                    var request = new HttpRequestMessage(HttpMethod.Get, _FilePath);

                    request.Headers.Range = new RangeHeaderValue(chunk.StartByte, chunk.EndByte);

                    using var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);

                    using var stream = await response.Content.ReadAsStreamAsync();


                    var buffer = new byte[1048576]; // a 1MB buffer for streaming the chunk

                    int bytesRead;

                    DateTime startTime = DateTime.Now;

                    using FileStream OutPutFileStream = new FileStream(FullSavinPath, FileMode.Open, FileAccess.Write, FileShare.Write, 1 << 23, true);
                    OutPutFileStream.Position = chunk.StartByte;

                    while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    {

                        chunk.BytesDownloaded += bytesRead;

                        chunk.RemainingSeconds = RemainingTimeBySeconds(startTime, chunk);
                        CallBack.Report(chunk);
                        try
                        {
                            await OutPutFileStream.WriteAsync(buffer, 0, bytesRead);
                        }
                        catch
                        {
                            Console.WriteLine("Wait a moment before retrying (exponential backoff is even better");
                            await Task.Delay(1000);
                        }
                    }

                }
                catch (Exception ex)
                {
                    // later
                }
            }


            public async Task start(IProgress<Chunk> ProgressCallBack)
            {
                Helpers.DownloadInfo? downloadInfo = await Helpers.GetDownloadInfo(_FilePath);

                if (downloadInfo == null)
                {
                    throw new Exception("the server that contains this file is not working");
                }
                if (!downloadInfo.Support_Range)
                {
                    throw new Exception("the server does not support range download");
                }
                this._FileSize = downloadInfo.TotalBytes;
                long chunkSize = downloadInfo.TotalBytes / 4;




                Task[] tasks = new Task[4];
                Chunk[] chunks = new Chunk[4];



                if (!CreateSavingFile())
                {
                    throw new Exception("cannot create the file in your machine. try running the app as an administrator or check your storage space");
                }


                for (int i = 0; i < 4; i++)
                {
                    int index = i;

                    Chunk chunk = new Chunk(
                                            index,
                                            index * chunkSize,
                                            index == 3 ? downloadInfo.TotalBytes - 1 : (index + 1) * chunkSize - 1,
                                            chunkSize,
                                            0);

                    chunks[i] = chunk;


                    tasks[i] = DownloadAndSaveShunk(chunk, ProgressCallBack);
                }
                await Task.WhenAll(tasks);

            }
        }
    }
}