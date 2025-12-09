namespace FileManager.Ui_Interfaces
{
    partial class DataGrid
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

        #region Component Designer generated code

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGrid));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            CancelAllBtn = new Guna.UI2.WinForms.Guna2Button();
            AddFilesBtn = new Guna.UI2.WinForms.Guna2Button();
            BrowseDirectoryBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            DirectoryTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            StartBtn = new Guna.UI2.WinForms.Guna2Button();
            FilesDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            FileName = new DataGridViewTextBoxColumn();
            FileExtention = new DataGridViewTextBoxColumn();
            FileSize = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            DeleteBtn = new DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)FilesDataGrid).BeginInit();
            SuspendLayout();
            // 
            // CancelAllBtn
            // 
            CancelAllBtn.BackColor = Color.Transparent;
            CancelAllBtn.BorderColor = Color.White;
            CancelAllBtn.BorderRadius = 20;
            CancelAllBtn.BorderThickness = 1;
            CancelAllBtn.CustomizableEdges = customizableEdges1;
            CancelAllBtn.DisabledState.BorderColor = Color.DarkGray;
            CancelAllBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            CancelAllBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CancelAllBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CancelAllBtn.FillColor = Color.FromArgb(64, 64, 64);
            CancelAllBtn.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            CancelAllBtn.ForeColor = Color.White;
            CancelAllBtn.Location = new Point(706, 461);
            CancelAllBtn.Name = "CancelAllBtn";
            CancelAllBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            CancelAllBtn.Size = new Size(144, 40);
            CancelAllBtn.TabIndex = 15;
            CancelAllBtn.Text = "Clear All";
            CancelAllBtn.Click += CancelAllBtn_Click;
            // 
            // AddFilesBtn
            // 
            AddFilesBtn.BackColor = Color.Transparent;
            AddFilesBtn.BorderColor = Color.White;
            AddFilesBtn.BorderRadius = 20;
            AddFilesBtn.BorderThickness = 1;
            AddFilesBtn.CustomizableEdges = customizableEdges3;
            AddFilesBtn.DisabledState.BorderColor = Color.DarkGray;
            AddFilesBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            AddFilesBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddFilesBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddFilesBtn.FillColor = Color.FromArgb(64, 64, 64);
            AddFilesBtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddFilesBtn.ForeColor = Color.White;
            AddFilesBtn.Location = new Point(856, 1);
            AddFilesBtn.Name = "AddFilesBtn";
            AddFilesBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            AddFilesBtn.Size = new Size(106, 34);
            AddFilesBtn.TabIndex = 14;
            AddFilesBtn.Text = "Add Files";
            AddFilesBtn.Click += AddFilesBtn_Click;
            // 
            // BrowseDirectoryBtn
            // 
            BrowseDirectoryBtn.CheckedState.ImageSize = new Size(64, 64);
            BrowseDirectoryBtn.HoverState.ImageSize = new Size(64, 64);
            BrowseDirectoryBtn.Image = (Image)resources.GetObject("BrowseDirectoryBtn.Image");
            BrowseDirectoryBtn.ImageOffset = new Point(0, 0);
            BrowseDirectoryBtn.ImageRotate = 0F;
            BrowseDirectoryBtn.ImageSize = new Size(60, 64);
            BrowseDirectoryBtn.Location = new Point(569, 1);
            BrowseDirectoryBtn.Name = "BrowseDirectoryBtn";
            BrowseDirectoryBtn.PressedState.ImageSize = new Size(64, 64);
            BrowseDirectoryBtn.ShadowDecoration.CustomizableEdges = customizableEdges5;
            BrowseDirectoryBtn.Size = new Size(49, 34);
            BrowseDirectoryBtn.TabIndex = 13;
            BrowseDirectoryBtn.Click += BrowseDirectoryBtn_Click;
            // 
            // DirectoryTextBox
            // 
            DirectoryTextBox.BorderRadius = 10;
            DirectoryTextBox.CustomizableEdges = customizableEdges6;
            DirectoryTextBox.DefaultText = "";
            DirectoryTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            DirectoryTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            DirectoryTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            DirectoryTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            DirectoryTextBox.FillColor = Color.FromArgb(25, 28, 35);
            DirectoryTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            DirectoryTextBox.Font = new Font("Segoe UI", 9F);
            DirectoryTextBox.ForeColor = Color.White;
            DirectoryTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            DirectoryTextBox.Location = new Point(164, 1);
            DirectoryTextBox.Name = "DirectoryTextBox";
            DirectoryTextBox.PlaceholderText = "";
            DirectoryTextBox.SelectedText = "";
            DirectoryTextBox.ShadowDecoration.CustomizableEdges = customizableEdges7;
            DirectoryTextBox.Size = new Size(399, 34);
            DirectoryTextBox.TabIndex = 12;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = Color.IndianRed;
            guna2HtmlLabel2.Location = new Point(3, 1);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(155, 26);
            guna2HtmlLabel2.TabIndex = 11;
            guna2HtmlLabel2.Text = "Output Directory";
            // 
            // StartBtn
            // 
            StartBtn.BackColor = Color.Transparent;
            StartBtn.BorderColor = Color.White;
            StartBtn.BorderRadius = 20;
            StartBtn.BorderThickness = 1;
            StartBtn.CustomizableEdges = customizableEdges8;
            StartBtn.DisabledState.BorderColor = Color.DarkGray;
            StartBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            StartBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            StartBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            StartBtn.FillColor = Color.FromArgb(64, 64, 64);
            StartBtn.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            StartBtn.ForeColor = Color.White;
            StartBtn.Location = new Point(856, 461);
            StartBtn.Name = "StartBtn";
            StartBtn.ShadowDecoration.CustomizableEdges = customizableEdges9;
            StartBtn.Size = new Size(106, 40);
            StartBtn.TabIndex = 10;
            StartBtn.Text = "Start";
            StartBtn.Click += StartBtn_Click;
            // 
            // FilesDataGrid
            // 
            FilesDataGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 48, 52);
            FilesDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            FilesDataGrid.BackgroundColor = Color.FromArgb(25, 28, 35);
            FilesDataGrid.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 16, 18);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            FilesDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            FilesDataGrid.ColumnHeadersHeight = 30;
            FilesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            FilesDataGrid.Columns.AddRange(new DataGridViewColumn[] { FileName, FileExtention, FileSize, Status, DeleteBtn });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(114, 117, 119);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            FilesDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            FilesDataGrid.GridColor = Color.FromArgb(50, 56, 62);
            FilesDataGrid.Location = new Point(3, 41);
            FilesDataGrid.Name = "FilesDataGrid";
            FilesDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HotTrack;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            FilesDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            FilesDataGrid.RowHeadersVisible = false;
            FilesDataGrid.Size = new Size(959, 414);
            FilesDataGrid.TabIndex = 9;
            FilesDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            FilesDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(44, 48, 52);
            FilesDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            FilesDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            FilesDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            FilesDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            FilesDataGrid.ThemeStyle.BackColor = Color.FromArgb(25, 28, 35);
            FilesDataGrid.ThemeStyle.GridColor = Color.FromArgb(50, 56, 62);
            FilesDataGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(15, 16, 18);
            FilesDataGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            FilesDataGrid.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            FilesDataGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            FilesDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            FilesDataGrid.ThemeStyle.HeaderStyle.Height = 30;
            FilesDataGrid.ThemeStyle.ReadOnly = false;
            FilesDataGrid.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(33, 37, 41);
            FilesDataGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            FilesDataGrid.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            FilesDataGrid.ThemeStyle.RowsStyle.ForeColor = Color.White;
            FilesDataGrid.ThemeStyle.RowsStyle.Height = 25;
            FilesDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(114, 117, 119);
            FilesDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            FilesDataGrid.CellMouseClick += FilesDataGrid_CellMouseClick;
            // 
            // FileName
            // 
            FileName.HeaderText = "File Name";
            FileName.Name = "FileName";
            FileName.Resizable = DataGridViewTriState.True;
            // 
            // FileExtention
            // 
            FileExtention.HeaderText = "File Extention";
            FileExtention.Name = "FileExtention";
            // 
            // FileSize
            // 
            FileSize.HeaderText = "File Size";
            FileSize.Name = "FileSize";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // DeleteBtn
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(25, 28, 35);
            dataGridViewCellStyle3.ForeColor = Color.Red;
            DeleteBtn.DefaultCellStyle = dataGridViewCellStyle3;
            DeleteBtn.HeaderText = "Action";
            DeleteBtn.LinkBehavior = LinkBehavior.AlwaysUnderline;
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Resizable = DataGridViewTriState.True;
            DeleteBtn.SortMode = DataGridViewColumnSortMode.Automatic;
            DeleteBtn.VisitedLinkColor = Color.Blue;
            // 
            // DataGrid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 28, 35);
            Controls.Add(CancelAllBtn);
            Controls.Add(AddFilesBtn);
            Controls.Add(BrowseDirectoryBtn);
            Controls.Add(DirectoryTextBox);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(StartBtn);
            Controls.Add(FilesDataGrid);
            Name = "DataGrid";
            Size = new Size(968, 507);
            ((System.ComponentModel.ISupportInitialize)FilesDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button CancelAllBtn;
        private Guna.UI2.WinForms.Guna2Button AddFilesBtn;
        private Guna.UI2.WinForms.Guna2ImageButton BrowseDirectoryBtn;
        private Guna.UI2.WinForms.Guna2TextBox DirectoryTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button StartBtn;
        public Guna.UI2.WinForms.Guna2DataGridView FilesDataGrid;
        private DataGridViewTextBoxColumn FileName;
        private DataGridViewTextBoxColumn FileExtention;
        private DataGridViewTextBoxColumn FileSize;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewLinkColumn DeleteBtn;
    }
}
