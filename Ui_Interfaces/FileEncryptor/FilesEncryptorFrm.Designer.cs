namespace FileManager.Ui_Interfaces
{
    partial class FilesEncryptorFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilesEncryptorFrm));
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dataGrid1 = new DataGrid();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.IndianRed;
            guna2HtmlLabel1.Location = new Point(399, 2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(238, 42);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Files Encryptor";
            // 
            // dataGrid1
            // 
            dataGrid1.BackColor = Color.FromArgb(25, 28, 35);
            dataGrid1.Location = new Point(28, 50);
            dataGrid1.Name = "dataGrid1";
            dataGrid1.Size = new Size(976, 519);
            dataGrid1.TabIndex = 2;
            // 
            // FilesEncryptorFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 28, 35);
            ClientSize = new Size(1008, 581);
            Controls.Add(dataGrid1);
            Controls.Add(guna2HtmlLabel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FilesEncryptorFrm";
            Text = "Files Encryptor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private DataGrid dataGrid1;
    }
}