using FileManager.Packages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager.Ui_Interfaces.FileCompressor
{
    public partial class FilesCompressorFrm : Form
    {
        public FilesCompressorFrm()
        {
            InitializeComponent();
            dataGrid1.FilesDataGrid.Columns[3].Visible = false;
            dataGrid1.OnStartButtonClicked += HandleStartButtonClicked;
            this.dataGrid1.SetDirectory(getLastUsedDirectory());
        }
        private void HandleStartButtonClicked()
        {
            StartCompressing();
        }
        private string getLastUsedDirectory()
        {
            try
            {
                return File.ReadAllText(@"..\..\..\resources\lastUsedDirectory.txt");
            }
            catch
            {
                return "";
            }
        }
        private async void StartCompressing()
        {
            string ZippedFilename = OutfilenameTextBox.Text;
            if (ZippedFilename == "")
            {
                MessageBox.Show("please provide the output file name", "file name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ZippedFilename = ZippedFilename.Replace(".zip", "");          
            string FinalOutputPath = dataGrid1.OutPutDirectory+ZippedFilename +".zip";
            ProgressBar.Visible = true;
            ProgressHtmlLabel.Visible = true;
            await Task.Run(() =>
            {
                Packages.FileCompressor.CompressFilesIntoZip(this.dataGrid1.Files.ToArray(), dataGrid1.OutPutDirectory, ZippedFilename + ".zip", 6,
                (progress) =>
                {
                    this.ProgressBar.Value = (int)progress;
                });
            });
     
        }

    }
}
