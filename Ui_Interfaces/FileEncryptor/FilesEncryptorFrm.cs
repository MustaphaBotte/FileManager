using FileManager.Packages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace FileManager.Ui_Interfaces
{
    public partial class FilesEncryptorFrm : Form
    {

        public FilesEncryptorFrm()
        {
            InitializeComponent();
            dataGrid1.OnStartButtonClicked += HandleStartButtonClicked;
            this.dataGrid1.SetDirectory(getLastUsedDirectory());
        }
        private void HandleStartButtonClicked()
        {
            StartEncryption();
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
        private void StartEncryption()
        {

            string outdirectory = dataGrid1.OutPutDirectory;
            string? password = LoginFrm.GetTheStoredUser()?.Password;
            byte[] key = new byte[0];
            if(PasswordManager.ValidatePasswordText(password??""))
            {
                key = FileEncryptor.GetTheStoredHash();
            }
            for (int i = 0; i < dataGrid1.Files.Count; i++)
            {
                dataGrid1.FilesDataGrid.Rows[i].Cells[3].Value = "In Progress";
                int index = i;
                Task.Run(() =>
                {
                    if (FileEncryptor.EncryptFile(key, dataGrid1.Files[index], outdirectory + @"\" +"Encrypted" +Path.GetFileName(dataGrid1.Files[index])))
                        this.dataGrid1.FilesDataGrid.Rows[index].Cells[3].Value = "Completed";
                    else
                        this.dataGrid1.FilesDataGrid.Rows[index].Cells[3].Value = "Failed";
                });

            }
        }

    }
}
