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
using static System.Net.Mime.MediaTypeNames;

namespace FileManager
{
    public partial class SignUpFrm : Form
    {
        public Action<string, string> OnCredentialsValid = delegate { };
        public SignUpFrm()
        {
            InitializeComponent();
        }

        private void GenPassButton1_Click(object sender, EventArgs e)
        {
            this.passwordTextBox.Text = PasswordGenerator.GenerateRandomPassword(16);
        }
        private void SaveKey(string key)
        {
            string Content = "============================================================================\n" +
                $"This is your 128 bit key : {key} \nDont share it with any one and keep it in a safe place\n" +
                "============================================================================";
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text File|*.txt";
            saveFile.FileName = "128bitEncryptionKey.txt";
            saveFile.Title = "Save your 128 bit key";
            try
            {
                if (DialogResult.OK == saveFile.ShowDialog())
                {
                    File.WriteAllText(saveFile.FileName, Content);
                }
            }
            catch
            {
                MessageBox.Show("cannot sign you up in the momemnt please try again", "Internal error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            
            string user = usernameTextBox.Text;
            string pass = this.passwordTextBox.Text;
            if (user == "")
            {
                MessageBox.Show("please provide your username", "Invalid username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pass.Length < 8)
            {
                MessageBox.Show("please provide a password with length bigger than 8 characters\n You can press the generate button to generate a strong password",
                    "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string key = this.EncKeyTextBox.Text;
            if (key != "")
            {
                MessageBox.Show("please save this 128 bit in some safe place.  you can use it to decrypt your files if" +
                " you forgot your login password", "importatnt info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveKey(key);
                this.OnCredentialsValid.Invoke(user, pass);
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("please generate 128 bit key for data encryption" 
               , "128 key is required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void showPassCheckedBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCheckedBox.Checked)
            {
                this.passwordTextBox.PasswordChar = '\0';
            }
            else
                this.passwordTextBox.PasswordChar = '*';

        }

        private void GenEncKeyBtn_Click(object sender, EventArgs e)
        {
            string password = this.passwordTextBox.Text;
            if(password.Length<8)
            {
                MessageBox.Show("this step is crucial please provide a password that is bigger that 8 chars\n" +
                    "based on that password we will generate a 128 bit key password for encryption", "invalid passwod", MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
                return;
            }
            this.EncKeyTextBox.Text = PasswordManager.Generate128BitKey(password);
        }
    }
}
