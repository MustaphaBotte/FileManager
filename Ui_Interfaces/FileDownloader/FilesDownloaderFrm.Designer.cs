namespace FileManager.Ui_Interfaces
{
    partial class FilesDownloaderFrm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilesDownloaderFrm));
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            DownloadDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            SiteUrl = new DataGridViewTextBoxColumn();
            SavingPath = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ActionBtn = new DataGridViewButtonColumn();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            AddTastBtn = new Guna.UI2.WinForms.Guna2Button();
            ClearAllBtn = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            StartAllBtn = new Guna.UI2.WinForms.Guna2Button();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)DownloadDataGrid).BeginInit();
            guna2Panel1.SuspendLayout();
            guna2ContextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(0, 0);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(97, 17);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "guna2HtmlLabel1";
            // 
            // DownloadDataGrid
            // 
            DownloadDataGrid.AllowUserToAddRows = false;
            DownloadDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(247, 248, 250);
            DownloadDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DownloadDataGrid.BackgroundColor = Color.FromArgb(25, 28, 35);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(40, 96, 144);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(10, 5, 10, 5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(40, 96, 144);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DownloadDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DownloadDataGrid.ColumnHeadersHeight = 40;
            DownloadDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DownloadDataGrid.Columns.AddRange(new DataGridViewColumn[] { SiteUrl, SavingPath, Status, ActionBtn });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DownloadDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            DownloadDataGrid.Dock = DockStyle.Fill;
            DownloadDataGrid.GridColor = Color.FromArgb(231, 229, 255);
            DownloadDataGrid.Location = new Point(306, 0);
            DownloadDataGrid.Name = "DownloadDataGrid";
            DownloadDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.Padding = new Padding(10, 5, 10, 5);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(240, 245, 250);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(40, 96, 144);
            DownloadDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            DownloadDataGrid.RowTemplate.Height = 35;
            DownloadDataGrid.Size = new Size(749, 587);
            DownloadDataGrid.TabIndex = 2;
            DownloadDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DownloadDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            DownloadDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DownloadDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DownloadDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DownloadDataGrid.ThemeStyle.BackColor = Color.FromArgb(25, 28, 35);
            DownloadDataGrid.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DownloadDataGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DownloadDataGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DownloadDataGrid.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DownloadDataGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DownloadDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DownloadDataGrid.ThemeStyle.HeaderStyle.Height = 40;
            DownloadDataGrid.ThemeStyle.ReadOnly = false;
            DownloadDataGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            DownloadDataGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DownloadDataGrid.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DownloadDataGrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DownloadDataGrid.ThemeStyle.RowsStyle.Height = 35;
            DownloadDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DownloadDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DownloadDataGrid.CellMouseClick += DownloadDataGrid_CellMouseClick;
            // 
            // SiteUrl
            // 
            SiteUrl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SiteUrl.FillWeight = 94.44444F;
            SiteUrl.HeaderText = "Site URL";
            SiteUrl.Name = "SiteUrl";
            SiteUrl.ReadOnly = true;
            SiteUrl.Resizable = DataGridViewTriState.True;
            // 
            // SavingPath
            // 
            SavingPath.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SavingPath.FillWeight = 94.44444F;
            SavingPath.HeaderText = "Saving Path";
            SavingPath.Name = "SavingPath";
            SavingPath.ReadOnly = true;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Status.HeaderText = "Progress";
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 94;
            // 
            // ActionBtn
            // 
            ActionBtn.HeaderText = "Action";
            ActionBtn.Name = "ActionBtn";
            ActionBtn.Resizable = DataGridViewTriState.True;
            ActionBtn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = Color.White;
            guna2HtmlLabel2.Location = new Point(25, 37);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(212, 39);
            guna2HtmlLabel2.TabIndex = 1;
            guna2HtmlLabel2.Text = "Files Downloader";
            // 
            // AddTastBtn
            // 
            AddTastBtn.Animated = true;
            AddTastBtn.BorderRadius = 8;
            AddTastBtn.CustomizableEdges = customizableEdges1;
            AddTastBtn.DisabledState.BorderColor = Color.DarkGray;
            AddTastBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            AddTastBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddTastBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddTastBtn.FillColor = Color.FromArgb(40, 96, 144);
            AddTastBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            AddTastBtn.ForeColor = Color.White;
            AddTastBtn.Location = new Point(25, 128);
            AddTastBtn.Name = "AddTastBtn";
            AddTastBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            AddTastBtn.Size = new Size(200, 45);
            AddTastBtn.TabIndex = 2;
            AddTastBtn.Text = "Add Download";
            AddTastBtn.Click += AddTastBtn_Click;
            // 
            // ClearAllBtn
            // 
            ClearAllBtn.Animated = true;
            ClearAllBtn.BorderRadius = 8;
            ClearAllBtn.CustomizableEdges = customizableEdges3;
            ClearAllBtn.DisabledState.BorderColor = Color.DarkGray;
            ClearAllBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ClearAllBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ClearAllBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ClearAllBtn.FillColor = Color.FromArgb(40, 96, 144);
            ClearAllBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            ClearAllBtn.ForeColor = Color.White;
            ClearAllBtn.Location = new Point(25, 254);
            ClearAllBtn.Name = "ClearAllBtn";
            ClearAllBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ClearAllBtn.Size = new Size(200, 45);
            ClearAllBtn.TabIndex = 3;
            ClearAllBtn.Text = "Clear All";
            ClearAllBtn.Click += ClearAllBtn_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(30, 32, 38);
            guna2Panel1.Controls.Add(StartAllBtn);
            guna2Panel1.Controls.Add(ClearAllBtn);
            guna2Panel1.Controls.Add(AddTastBtn);
            guna2Panel1.Controls.Add(guna2HtmlLabel2);
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.Dock = DockStyle.Left;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(306, 587);
            guna2Panel1.TabIndex = 3;
            // 
            // StartAllBtn
            // 
            StartAllBtn.Animated = true;
            StartAllBtn.BorderRadius = 8;
            StartAllBtn.CustomizableEdges = customizableEdges5;
            StartAllBtn.DisabledState.BorderColor = Color.DarkGray;
            StartAllBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            StartAllBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            StartAllBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            StartAllBtn.FillColor = Color.FromArgb(40, 96, 144);
            StartAllBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            StartAllBtn.ForeColor = Color.White;
            StartAllBtn.Location = new Point(25, 190);
            StartAllBtn.Name = "StartAllBtn";
            StartAllBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            StartAllBtn.Size = new Size(200, 45);
            StartAllBtn.TabIndex = 5;
            StartAllBtn.Text = "Start All";
            StartAllBtn.Click += StartAllBtn_Click;
            // 
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // FilesDownloaderFrm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1055, 587);
            Controls.Add(DownloadDataGrid);
            Controls.Add(guna2Panel1);
            Controls.Add(guna2HtmlLabel1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "FilesDownloaderFrm";
            Text = "Files Downloader";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DownloadDataGrid).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2ContextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView DownloadDataGrid;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button AddTastBtn;
        private Guna.UI2.WinForms.Guna2Button ClearAllBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button StartAllBtn;
        private DataGridViewTextBoxColumn SiteUrl;
        private DataGridViewTextBoxColumn SavingPath;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn ActionBtn;
    }
}