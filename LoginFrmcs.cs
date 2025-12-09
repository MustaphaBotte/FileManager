using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FileManager
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
            FillCredentials();
        }


        private static readonly string RememberingFilePath = @"..\..\..\resources\LoginCredentials.json";
        public class LoginData
        {
            public string Username { get; set; } = "";
            public string Password { get; set; } = "";

            public bool RememberMe { get; set; } = false;
        }
        private void SignUpLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (SignUpFrm signUp = new SignUpFrm())
            {
                signUp.OnCredentialsValid += (string user, string pass) =>
                {
                    this.usernameTextBox.Text = user;
                    this.passwordTextBox.Text = pass;
                    RememberTheUser(user, pass,false);
                };
                signUp.ShowDialog();
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
        public static LoginData? GetTheStoredUser()
        {
            if (!File.Exists(RememberingFilePath))
            {
                return null;
            }
            IEnumerable<string> Users = File.ReadLines(RememberingFilePath);
            foreach (string userLine in Users)
            {
                LoginData? user = JsonSerializer.Deserialize<LoginData>(userLine);
                if (user != null)
                {
                    return user;
                }
                return null;
            }
            return null;
        }
        public static void RememberTheUser(string user, string pass,bool rememberme)
        {
            if (user == "" || pass == "") { return; }

            var LoginData = new LoginData { Username=user,Password = pass,RememberMe= rememberme};
            string jsonformat = JsonSerializer.Serialize(LoginData);

            if (jsonformat != null)
            {
                if (!File.Exists(RememberingFilePath))
                {
                    File.Create(RememberingFilePath).Close();
                }
                File.WriteAllText(RememberingFilePath, jsonformat + Environment.NewLine, encoding: Encoding.UTF8);
            }

        }
        private void FillCredentials()
        {
            LoginData? user = GetTheStoredUser();
            if (user != null && user.RememberMe)
            {
                this.usernameTextBox.Text = user.Username;
                this.passwordTextBox.Text = user.Password;
            }
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {

            LoginData? user = GetTheStoredUser();
            if(user?.Username !=usernameTextBox.Text||
                user?.Password !=passwordTextBox.Text)
            {
                MessageBox.Show("wrong username or password", "invalid credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RememberTheUser(user.Username, user.Password, this.rememberMeCheckBox.Checked);
            using(DashBoard dashBoard = new DashBoard())
            {
             dashBoard.ShowDialog();
            }
            
        }
    }
}
