using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static FileManager.Packages.FileDownloader;

namespace FileManager.Packages
{
    public class FileDownloader
    {
        public class TaskInfo : EventArgs
        {
            public int ID;
            public string Url = "";
            public string DownloadPath = "";

            public TaskInfo(string url, string downloadPath)
            {
                Url = url;
                DownloadPath = downloadPath;
            }
        }
        private  void SaveToFile(TaskInfo taskInfo, byte[] data)
        {
            try
            {
                string FileName = taskInfo.Url.Replace("https://", "").Replace("http://", "").Replace("/", "_");
                string Extention = "." + DetectFileType(data);

                int index = 0;
                while (File.Exists(Path.Combine(taskInfo.DownloadPath, FileName + Extention)))
                {
                    FileName += $"{index}";
                    index++;
                }
                using (FileStream stream = new FileStream(Path.Combine(taskInfo.DownloadPath, FileName + Extention), FileMode.Create))
                {
                    stream.Write(data, 0, data.Length);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void Download(TaskInfo taskInfo, Action<int,int>CallBack)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls13;

            try
            {
                using (WebClient web = new WebClient())
                {
                    byte[] data = new byte[0];
                    web.Headers[HttpRequestHeader.UserAgent] =
                                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 " +
                                "(KHTML, like Gecko) Chrome/126.0.0.0 Safari/537.36";
                    web.Headers[HttpRequestHeader.Accept] =
                        "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                    web.Headers[HttpRequestHeader.AcceptLanguage] = "en-US,en;q=0.9";

                    web.DownloadProgressChanged += (sender, e) =>
                    {
                        CallBack.Invoke(e.ProgressPercentage, taskInfo.ID);
                    };
                    web.DownloadDataAsync(new Uri(taskInfo.Url), taskInfo.ID);
                    web.DownloadDataCompleted += (sender, e) =>
                    {
                        data = e.Result;
                        SaveToFile(taskInfo, data);
                    };
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }




        // i get this function from the internet to detect the file content to save the file with extention
        private string DetectFileType(byte[] data)
        {
            if (data.Length < 12) return "bin";

            // PNG - ‰PNG
            if (data[0] == 0x89 && data[1] == 0x50 && data[2] == 0x4E && data[3] == 0x47)
                return "png";

            // JPEG - FF D8 FF
            if (data[0] == 0xFF && data[1] == 0xD8 && data[2] == 0xFF)
                return "jpg";

            // GIF87a or GIF89a - GIF
            if (data[0] == 0x47 && data[1] == 0x49 && data[2] == 0x46 && data[3] == 0x38 && (data[4] == 0x37 || data[4] == 0x39) && data[5] == 0x61)
                return "gif";

            // BMP - BM
            if (data[0] == 0x42 && data[1] == 0x4D)
                return "bmp";

            // PDF - %PDF
            if (data[0] == 0x25 && data[1] == 0x50 && data[2] == 0x44 && data[3] == 0x46)
                return "pdf";

            // ZIP/Office docs - PK (also APK, JAR, etc)
            if (data[0] == 0x50 && data[1] == 0x4B)
                return "zip";

            // WEBP - RIFF....WEBP
            if (data[0] == 0x52 && data[1] == 0x49 && data[2] == 0x46 && data[3] == 0x46 &&
                data[8] == 0x57 && data[9] == 0x45 && data[10] == 0x42 && data[11] == 0x50)
                return "webp";

            // VIDEO FORMATS

            // MP4, MOV, 3GP - ftyp
            if (data[4] == 0x66 && data[5] == 0x74 && data[6] == 0x79 && data[7] == 0x70)
            {
                // Check specific MP4 subtypes
                if (data[8] == 0x69 && data[9] == 0x73 && data[10] == 0x6F && data[11] == 0x6D) // isom
                    return "mp4";
                if (data[8] == 0x4D && data[9] == 0x53 && data[10] == 0x4E && data[11] == 0x56) // MSNV
                    return "mp4";
                if (data[8] == 0x6D && data[9] == 0x70 && data[10] == 0x34 && data[11] == 0x32) // mp42
                    return "mp4";
                return "mp4"; // generic MP4
            }

            // AVI - RIFF....AVI
            if (data[0] == 0x52 && data[1] == 0x49 && data[2] == 0x46 && data[3] == 0x46 &&
                data[8] == 0x41 && data[9] == 0x56 && data[10] == 0x49 && data[11] == 0x20)
                return "avi";

            // MKV (WebM) - 1A 45 DF A3
            if (data[0] == 0x1A && data[1] == 0x45 && data[2] == 0xDF && data[3] == 0xA3)
                return "mkv";

            // FLV - FLV
            if (data[0] == 0x46 && data[1] == 0x4C && data[2] == 0x56 && data[3] == 0x01)
                return "flv";

            // WMV - 30 26 B2 75 8E 66 CF 11 A6 D9 00 AA 00 62 CE 6C
            if (data[0] == 0x30 && data[1] == 0x26 && data[2] == 0xB2 && data[3] == 0x75 &&
                data[4] == 0x8E && data[5] == 0x66 && data[6] == 0xCF && data[7] == 0x11 &&
                data[8] == 0xA6 && data[9] == 0xD9 && data[10] == 0x00 && data[11] == 0xAA)
                return "wmv";

            // MPEG/MPG - 00 00 01 BA or 00 00 01 B3
            if (data[0] == 0x00 && data[1] == 0x00 && data[2] == 0x01 &&
                (data[3] == 0xBA || data[3] == 0xB3))
                return "mpg";

            // WebM - 1A 45 DF A3 (same as MKV but with WebM specific)
            if (data[0] == 0x1A && data[1] == 0x45 && data[2] == 0xDF && data[3] == 0xA3)
            {
                // Check if it's specifically WebM
                try
                {
                    string webmCheck = Encoding.UTF8.GetString(data, 0, Math.Min(50, data.Length));
                    if (webmCheck.Contains("webm") || webmCheck.Contains("matroska"))
                        return "webm";
                }
                catch { }
                return "mkv";
            }

            // QuickTime MOV - moov or mdat
            if ((data[4] == 0x6D && data[5] == 0x6F && data[6] == 0x6F && data[7] == 0x76) ||
                (data[4] == 0x6D && data[5] == 0x64 && data[6] == 0x61 && data[7] == 0x74))
                return "mov";

            // Check for text/HTML content
            try
            {
                string start = Encoding.UTF8.GetString(data, 0, Math.Min(100, data.Length));
                if (start.ToLower().Contains("<html") || start.ToLower().Contains("<!doctype"))
                    return "html";
                if (start.ToLower().Contains("<?xml"))
                    return "xml";
                if (start.TrimStart().StartsWith("{")) // JSON
                    return "json";
                if (start.TrimStart().StartsWith("[")) // JSON array
                    return "json";
            }
            catch { }

            return "bin"; // binary as fallback
        }

    }
}
