namespace FileManager.Ui_Interfaces.FileCompressor
{
    partial class FilesCompressorFrm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilesCompressorFrm));
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dataGrid1 = new DataGrid();
            OutfilenameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            ProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            ProgressHtmlLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.IndianRed;
            guna2HtmlLabel1.Location = new Point(375, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(265, 42);
            guna2HtmlLabel1.TabIndex = 4;
            guna2HtmlLabel1.Text = "Files Compressor";
            // 
            // dataGrid1
            // 
            dataGrid1.BackColor = Color.FromArgb(25, 28, 35);
            dataGrid1.Location = new Point(12, 70);
            dataGrid1.Name = "dataGrid1";
            dataGrid1.Size = new Size(968, 507);
            dataGrid1.TabIndex = 3;
            // 
            // OutfilenameTextBox
            // 
            OutfilenameTextBox.BorderRadius = 10;
            OutfilenameTextBox.CustomizableEdges = customizableEdges1;
            OutfilenameTextBox.DefaultText = "";
            OutfilenameTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            OutfilenameTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            OutfilenameTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            OutfilenameTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            OutfilenameTextBox.FillColor = Color.FromArgb(25, 28, 35);
            OutfilenameTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            OutfilenameTextBox.Font = new Font("Segoe UI", 9F);
            OutfilenameTextBox.ForeColor = Color.White;
            OutfilenameTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            OutfilenameTextBox.Location = new Point(649, 72);
            OutfilenameTextBox.Name = "OutfilenameTextBox";
            OutfilenameTextBox.PlaceholderForeColor = Color.White;
            OutfilenameTextBox.PlaceholderText = "Output file name";
            OutfilenameTextBox.SelectedText = "";
            OutfilenameTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            OutfilenameTextBox.Size = new Size(195, 34);
            OutfilenameTextBox.TabIndex = 13;
            // 
            // ProgressBar
            // 
            ProgressBar.BorderColor = Color.White;
            ProgressBar.BorderRadius = 5;
            ProgressBar.BorderThickness = 1;
            ProgressBar.CustomizableEdges = customizableEdges3;
            ProgressBar.FillColor = Color.FromArgb(25, 28, 35);
            ProgressBar.Location = new Point(99, 536);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ProgressBar.Size = new Size(553, 30);
            ProgressBar.TabIndex = 14;
            ProgressBar.Text = "guna2ProgressBar1";
            ProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ProgressBar.Value = 1;
            ProgressBar.Visible = false;
            // 
            // ProgressHtmlLabel
            // 
            ProgressHtmlLabel.BackColor = Color.Transparent;
            ProgressHtmlLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProgressHtmlLabel.ForeColor = Color.White;
            ProgressHtmlLabel.Location = new Point(12, 536);
            ProgressHtmlLabel.Name = "ProgressHtmlLabel";
            ProgressHtmlLabel.Size = new Size(81, 26);
            ProgressHtmlLabel.TabIndex = 15;
            ProgressHtmlLabel.Text = "Progress";
            ProgressHtmlLabel.Visible = false;
            // 
            // FilesCompressorFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 28, 35);
            ClientSize = new Size(999, 646);
            Controls.Add(ProgressHtmlLabel);
            Controls.Add(ProgressBar);
            Controls.Add(OutfilenameTextBox);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(dataGrid1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FilesCompressorFrm";
            Text = "Files Compressor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private DataGrid dataGrid1;
        private Guna.UI2.WinForms.Guna2TextBox OutfilenameTextBox;
        private Guna.UI2.WinForms.Guna2ProgressBar ProgressBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel ProgressHtmlLabel;
    }
}