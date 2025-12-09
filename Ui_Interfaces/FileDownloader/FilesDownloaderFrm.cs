using System;
using System.Diagnostics;
using FileManager.Packages;
namespace FileManager.Ui_Interfaces
{
    public partial class FilesDownloaderFrm : Form
    {

        public FilesDownloaderFrm()
        {
            InitializeComponent();

        }

        private void AddTastBtn_Click(object sender, EventArgs e)
        {
            GetTastInfoFrm Frm = new GetTastInfoFrm();
            Frm.OnDownloadInfoReady += (object? snd, Packages.FileDownloader.TaskInfo tastInfo) =>
            {
               // ((Form)snd).Close();
                AddDataToTheGrid(tastInfo);
            };
            if (!Frm.IsDisposed)
                Frm.Show();
        }
        private void AddDataToTheGrid(Packages.FileDownloader.TaskInfo tastInfo)
        {
            int row = DownloadDataGrid.Rows.Add();
            DownloadDataGrid.Rows[row].Cells[0].Value = tastInfo.Url;
            DownloadDataGrid.Rows[row].Cells[1].Value = tastInfo.DownloadPath;
            DownloadDataGrid.Rows[row].Cells[2].Value = "0%";
            DownloadDataGrid.Rows[row].Cells[3].Value = "Start";
            tastInfo.ID = row;
            DownloadDataGrid.Rows[row].Tag = tastInfo;
        }
        private void ManageThreads(EventArgs taskInfo)
        {
            Thread t = new Thread(() => { Download((FileDownloader.TaskInfo)taskInfo); });
            t.Start();
        }
        private void Download(FileDownloader.TaskInfo taskInfo)
        {
            try
            {
                FileDownloader downloader = new FileDownloader();
                downloader.Download(taskInfo, (progress, ID) =>
                {
                    this.DownloadDataGrid.Rows[ID].Cells[2].Value = progress+"%";
                    if(progress>=100)
                    {
                        this.DownloadDataGrid.Rows[ID].Cells[3].Value = "Open File Explorer";
                    }
                });
            }
            catch
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DownloadDataGrid.Columns[0].Width = 120;
            this.DownloadDataGrid.Columns[1].Width = 100;
            this.DownloadDataGrid.Columns[2].Width = 100;
            this.DownloadDataGrid.Columns[3].Width = 120;
        }

        private void DownloadDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DownloadDataGrid.Columns[e.ColumnIndex].Name == "ActionBtn" && DownloadDataGrid.Rows[e.RowIndex]?.Cells[e.ColumnIndex]?.Value.ToString() == "Start")
            {
                FileDownloader.TaskInfo? TaskInfo = (FileDownloader.TaskInfo)DownloadDataGrid.Rows[e.RowIndex].Tag;
                ManageThreads(TaskInfo);
                DownloadDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "In progress";
            }
            else if (DownloadDataGrid.Rows[e.RowIndex]?.Cells[e.ColumnIndex]?.Value.ToString() == "Open File Explorer")
            {
                Process.Start(new ProcessStartInfo("explorer.exe", ((FileDownloader.TaskInfo)DownloadDataGrid.Rows[e.RowIndex].Tag).DownloadPath));
            }
            if (e.Button == MouseButtons.Right)
            {
                this.guna2ContextMenuStrip1.Show(Cursor.Position);
            }
        }
      
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.DownloadDataGrid.SelectedRows[0];
            DownloadDataGrid.Rows.Remove(row);
        }

        private void ClearAllBtn_Click(object sender, EventArgs e)
        {
            DownloadDataGrid.Rows.Clear();
        }

        private void StartAllBtn_Click(object sender, EventArgs e)
        {
            for(int i =0;i<DownloadDataGrid?.Rows.Count;i++)
            {
                var status = this.DownloadDataGrid?.Rows[i]?.Cells[3]?.Value;
                if (status?.ToString() != "Open File Explorer")
                {
                    DownloadDataGrid.Rows[i].Cells[3].Value = "In progress";
                    ManageThreads((FileDownloader.TaskInfo)DownloadDataGrid.Rows[i]?.Tag);
                }
            }
        }
    }
}
