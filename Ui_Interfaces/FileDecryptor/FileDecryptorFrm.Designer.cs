namespace FileManager.Ui_Interfaces.FileDecryptor
{
    partial class FilesDecryptorFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilesDecryptorFrm));
            dataGrid1 = new DataGrid();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // dataGrid1
            // 
            dataGrid1.BackColor = Color.FromArgb(25, 28, 35);
            dataGrid1.Location = new Point(28, 68);
            dataGrid1.Name = "dataGrid1";
            dataGrid1.Size = new Size(968, 507);
            dataGrid1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.IndianRed;
            guna2HtmlLabel1.Location = new Point(391, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(237, 42);
            guna2HtmlLabel1.TabIndex = 2;
            guna2HtmlLabel1.Text = "Files Decryptor";
            // 
            // FilesDecryptorFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 28, 35);
            ClientSize = new Size(1019, 601);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(dataGrid1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FilesDecryptorFrm";
            Text = "Files Decryptor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGrid dataGrid1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}