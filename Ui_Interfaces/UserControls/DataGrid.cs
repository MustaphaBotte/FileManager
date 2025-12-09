using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileManager.Packages;
using System.Security.Cryptography.X509Certificates;

namespace FileManager.Ui_Interfaces
{
    public partial class DataGrid : UserControl
    {
        public string OutPutDirectory = "";
        public  List<string> Files = new List<string>();

        public Action OnStartButtonClicked = delegate { };
        public Action OnCancelButtonClicked = delegate { };

        public DataGrid()
        {
            InitializeComponent();
        }
        private void BrowseDirectoryBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (DialogResult.OK == folder.ShowDialog())
            {
                OutPutDirectory = folder.SelectedPath;
                this.DirectoryTextBox.Text = OutPutDirectory;
                StoreCurrentDirectoryPath(OutPutDirectory);
            }
        }
        private void AddFilesToTheGrid(string[] Data)
        {
            long[] sizes = Packages.FileCompressor.GetFilesSize(Data);
            for (int i = 0; i < Data.Length; i++)
            {
                int index = FilesDataGrid.Rows.Add();
                FilesDataGrid.Rows[index].Cells[0].Value = Path.GetFileName(Data[i]);
                FilesDataGrid.Rows[index].Cells[1].Value = Path.GetExtension(Data[i]);
                FilesDataGrid.Rows[index].Cells[2].Value = (((decimal)sizes[i] / 1000) / 1000).ToString("F3") + "MB";
                FilesDataGrid.Rows[index].Cells[3].Value = "Suspended";
                FilesDataGrid.Rows[index].Cells[4].Value = "delete";
            }
        }
        private void AddFilesBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "All Files (*.*)|*.*";
            fileDialog.Multiselect = true;
            if (DialogResult.OK == fileDialog.ShowDialog())
            {
                foreach (string file in fileDialog.FileNames)
                {
                    Files.Add(file);
                }
            }

            AddFilesToTheGrid(Files.TakeLast(fileDialog.FileNames.Length).ToArray());
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            if(this.DirectoryTextBox.Text=="")
            {
                MessageBox.Show("please provide the output directory", "Missing directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!Directory.Exists(this.DirectoryTextBox.Text))
            {
                MessageBox.Show($"this directory {DirectoryTextBox.Text}\n is not exist", "Missing directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }      
            if(this.FilesDataGrid.Rows.Count==0)
            {
                MessageBox.Show($"please add atleast one file", "missing files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OnStartButtonClicked.Invoke();
        }
        private void CancelAllBtn_Click(object sender, EventArgs e)
        {        
            OnCancelButtonClicked.Invoke();
            this.Files.Clear();
            this.FilesDataGrid.Rows.Clear();
        }
        private void FilesDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                Files.RemoveAt(e.RowIndex);
                FilesDataGrid.Rows.RemoveAt(e.RowIndex);
            }
        }

        public void SetDirectory(string directory)
        {
            this.DirectoryTextBox.Text = directory;
            this.OutPutDirectory = directory;
        }

        public void StoreCurrentDirectoryPath(string directory)
        {
            try
            {
                 File.WriteAllText(@"..\..\..\resources\lastUsedDirectory.txt",directory);
            }
            catch
            {
                
            }
        }

    }
}
