
using Guna.UI2.WinForms;
using Downloader = FileManager.Libraries.DownloadAccelerator.Downloader;

namespace FileManager.Ui_Interfaces.ChunkChunkDownloader
{
    public partial class ChunkChunkDownloaderFrm : Form
    {
        Guna2ProgressBar[] ProgressBars = new Guna2ProgressBar[4];
        Guna2HtmlLabel[] ChunkLabels = new Guna2HtmlLabel[4];
        int[] ChunksRemainintSeconds = new int[4];
        double[] ChunksDownloadSpeed = new double[4];

        public ChunkChunkDownloaderFrm()
        {
            InitializeComponent();
            ProgressBars[0] = chunk0ProgressBar;
            ProgressBars[1] = chunk1ProgressBar;
            ProgressBars[2] = chunk2ProgressBar;
            ProgressBars[3] = chunk3ProgressBar;

            ChunkLabels[0] = chunk0Label;
            ChunkLabels[1] = chunk1Label;
            ChunkLabels[2] = chunk2Label;
            ChunkLabels[3] = chunk3Label;

        }

        private void browseFolderButton_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string folderPath = fbd.SelectedPath;
                this.savingPathTextBox.Text = folderPath;
            }
        }

        private void ProgressHandler(Downloader.Chunk chunk)
        {
            int Percent = (int)chunk.Percentage;

            ProgressBars[chunk.ChunkIndex].Value = Percent;
            ChunksRemainintSeconds[chunk.ChunkIndex] = chunk.RemainingSeconds;
            ChunkLabels[chunk.ChunkIndex].Text = $"Chunk {chunk.ChunkIndex} ({Percent}%)";
            ChunksDownloadSpeed[chunk.ChunkIndex] = chunk.bytesPerSecond/ 1_000_000.0;
        }
        private async void StartDownloading(string FilePath, string SavingDir)
        {
            try
            {
                Downloader downloader = new Downloader(FilePath, SavingDir);
                Progress<Downloader.Chunk> progress = new Progress<Downloader.Chunk>((chunk) => ProgressHandler(chunk));
                this.statusLabel.Text = "Running";
                await downloader.start(progress);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void startDownloadButton_Click(object sender, EventArgs e)
        {
            string Url = urlTextBox.Text;
            string SavingPath = savingPathTextBox.Text;
            if (!Uri.TryCreate(Url, UriKind.Absolute, out Uri? uri))
            {
                MessageBox.Show("The Url provided is not valid !", "Bad Url", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(SavingPath))
            {
                MessageBox.Show("The saving directory does not exist", "Bad Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StartDownloading(Url, SavingPath);
        }

        private void chunkProgressBar_ValueChanged(object sender, EventArgs e)
        {
            float TotalPercent= 0;
            int TotalRemainingSeconds = 0;
            double TotalDownloadSpeed = 0;

            for(int i=0;i<ProgressBars.Length;i++)
            {
                TotalPercent += ProgressBars[i].Value;
                TotalRemainingSeconds += ChunksRemainintSeconds[i];
                TotalDownloadSpeed += ChunksDownloadSpeed[i];
            }

            double AvgDownloadSpeed = TotalDownloadSpeed / 4;
            TotalPercent /= 4;



            overallProgressBar.Value = (int)TotalPercent;
            overallPercentageLabel.Text = $"{TotalPercent.ToString("F1")}%";
            speedLabel.Text = AvgDownloadSpeed.ToString("F1")+ " MB/s";

            string ETA = TimeSpan.FromSeconds(TotalRemainingSeconds).ToString(@"hh\:mm\:ss");
            etaLabel.Text = $"ETA: {ETA}";

            if (TotalPercent == 100)
            {
                statusLabel.Text = "Completed";
                statusLabel.ForeColor = Color.Green;
            }
        }
    }
}
