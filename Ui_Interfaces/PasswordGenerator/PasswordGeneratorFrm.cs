using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager.Ui_Interfaces.PasswordGenerator
{
    public partial class PasswordGeneratorFrm : Form
    {
        public PasswordGeneratorFrm()
        {
            InitializeComponent();
        }

        private void GenNormalPassBtn_Click(object sender, EventArgs e)
        {
            this.NormalPasswordTextBox.Text = Packages.PasswordGenerator.GenerateRandomCombinedPassword((int)NumericUpDown.Value,
                   upperscheck.Checked, lowerscheck.Checked, numbersCheck.Checked, symbolscheck.Checked);
        }

        private void GenKeyBtn_Click(object sender, EventArgs e)
        {
            this.KeyPasswordTextBox.Text = Packages.PasswordGenerator.Generate128bitkey();
        }

        private void GenHashBtn_Click(object sender, EventArgs e)
        {
            string password = UserinputpasswordTextBox.Text;
            if (password.Length < 8)
            {
                MessageBox.Show("please provide a password length bigger than 8 characters", "invalid password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HashTextBox.Text = Packages.PasswordGenerator.GenerateHash(plaintext: password);
        }

        private void SaveToFile(string title, string filename, string password)
        {
            string Content = "============================================================================\n" +
                $"This is your {title} : {password} \nDont share it with any one and keep it in a safe place\n" +
                "============================================================================";
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text File|*.txt";
            saveFile.FileName = $"{filename}.txt";
            saveFile.Title = $"Save your {title}";
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

        private void SaveNormalPassLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(NormalPasswordTextBox.Text.Length<8)
            {
                MessageBox.Show("password not valid!\n dont modify the generated password content", "invalid password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveToFile("Password", "Generated Password", NormalPasswordTextBox.Text);
        }

        private void SaveKeyLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (KeyPasswordTextBox.Text.Length <32)
            {
                MessageBox.Show("the 128 bit key is  not valid!\n dont modify the generated key", "invalid key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveToFile("128 Bit Key", "Generated 128bit Key", KeyPasswordTextBox.Text);
        }

        private void SaveHashLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {        
            SaveToFile("Hash", "Generated Hash", HashTextBox.Text);
        }
    }
}
