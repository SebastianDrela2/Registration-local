namespace Registration
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.DATA_GRID = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.LINK_LBL_GITHUB = new System.Windows.Forms.LinkLabel();
            this.LBL_GiTHUB = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlConnectionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.columnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IMG_BOX_TITLE = new System.Windows.Forms.PictureBox();
            this.LBL_CONNECTION = new System.Windows.Forms.Label();
            this.LBL_CONNECTION_STATUS = new System.Windows.Forms.Label();
            this.BTN_SQL_INFO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DATA_GRID)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_BOX_TITLE)).BeginInit();
            this.SuspendLayout();
            // 
            // DATA_GRID
            // 
            this.DATA_GRID.AllowDrop = true;
            this.DATA_GRID.AllowUserToAddRows = false;
            this.DATA_GRID.AllowUserToDeleteRows = false;
            this.DATA_GRID.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.NullValue = null;
            this.DATA_GRID.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DATA_GRID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DATA_GRID.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DATA_GRID.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DATA_GRID.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DATA_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATA_GRID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name_,
            this.Surname,
            this.RegistrationStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DATA_GRID.DefaultCellStyle = dataGridViewCellStyle2;
            this.DATA_GRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DATA_GRID.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.DATA_GRID.Location = new System.Drawing.Point(22, 127);
            this.DATA_GRID.Name = "DATA_GRID";
            this.DATA_GRID.RowTemplate.Height = 25;
            this.DATA_GRID.Size = new System.Drawing.Size(525, 246);
            this.DATA_GRID.TabIndex = 5;
            this.DATA_GRID.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.OnCellBeginEdit);
            
            this.DATA_GRID.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnDataGridCellValueChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Name_
            // 
            this.Name_.HeaderText = "Name";
            this.Name_.Name = "Name_";
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            // 
            // RegistrationStatus
            // 
            this.RegistrationStatus.HeaderText = "RegStatus";
            this.RegistrationStatus.Name = "RegistrationStatus";
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.Location = new System.Drawing.Point(23, 89);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(83, 30);
            this.BTN_ADD.TabIndex = 6;
            this.BTN_ADD.Text = "ADD ROW";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            this.BTN_ADD.Click += new System.EventHandler(this.OnAddClicked);
            // 
            // LINK_LBL_GITHUB
            // 
            this.LINK_LBL_GITHUB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LINK_LBL_GITHUB.AutoSize = true;
            this.LINK_LBL_GITHUB.Location = new System.Drawing.Point(463, 376);
            this.LINK_LBL_GITHUB.Name = "LINK_LBL_GITHUB";
            this.LINK_LBL_GITHUB.Size = new System.Drawing.Size(229, 13);
            this.LINK_LBL_GITHUB.TabIndex = 8;
            this.LINK_LBL_GITHUB.TabStop = true;
            this.LINK_LBL_GITHUB.Text = "https://github.com/Frosky404?tab=repositories";
            this.LINK_LBL_GITHUB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnGithubLinkClicked);
            // 
            // LBL_GiTHUB
            // 
            this.LBL_GiTHUB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_GiTHUB.AutoSize = true;
            this.LBL_GiTHUB.Font = new System.Drawing.Font("Sitka Subheading", 9F);
            this.LBL_GiTHUB.Location = new System.Drawing.Point(417, 374);
            this.LBL_GiTHUB.Name = "LBL_GiTHUB";
            this.LBL_GiTHUB.Size = new System.Drawing.Size(48, 18);
            this.LBL_GiTHUB.TabIndex = 9;
            this.LBL_GiTHUB.Text = "Github:";
            
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.editToolStripMenuItem2,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 16;
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.addToolStripMenuItem1,
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem1,
            this.saveasToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sqlConnectionToolStripMenuItem1});
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.addToolStripMenuItem1.Text = "Add";
            // 
            // sqlConnectionToolStripMenuItem1
            // 
            this.sqlConnectionToolStripMenuItem1.Name = "sqlConnectionToolStripMenuItem1";
            this.sqlConnectionToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.sqlConnectionToolStripMenuItem1.Text = "SQL Server connection";
            this.sqlConnectionToolStripMenuItem1.Click += new System.EventHandler(this.OnAddConnectionClicked);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.OnOpenClicked);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.OnSaveClicked);
            // 
            // saveasToolStripMenuItem1
            // 
            this.saveasToolStripMenuItem1.Name = "saveasToolStripMenuItem1";
            this.saveasToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.saveasToolStripMenuItem1.Text = "Saveas";
            this.saveasToolStripMenuItem1.Click += new System.EventHandler(this.OnSaveAsClicked);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.OnExitClicked);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem1});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.editToolStripMenuItem1.Text = "Search";
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.searchToolStripMenuItem1.Text = "Search";
            this.searchToolStripMenuItem1.Click += new System.EventHandler(this.searchToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem2
            // 
            this.editToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.columnsToolStripMenuItem,
            this.dataStyleToolStripMenuItem,
            this.sortToolStripMenuItem});
            this.editToolStripMenuItem2.Name = "editToolStripMenuItem2";
            this.editToolStripMenuItem2.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem2.Text = "Edit";
            // 
            // columnsToolStripMenuItem
            // 
            this.columnsToolStripMenuItem.Name = "columnsToolStripMenuItem";
            this.columnsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.columnsToolStripMenuItem.Text = "Columns";
            this.columnsToolStripMenuItem.Click += new System.EventHandler(this.columnsToolStripMenuItem_Click);
            // 
            // dataStyleToolStripMenuItem
            // 
            this.dataStyleToolStripMenuItem.Name = "dataStyleToolStripMenuItem";
            this.dataStyleToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.dataStyleToolStripMenuItem.Text = "DataStyle";
            this.dataStyleToolStripMenuItem.Click += new System.EventHandler(this.dataStyleToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.sortToolStripMenuItem.Text = "Sort";
            this.sortToolStripMenuItem.Click += new System.EventHandler(this.sortToolStripMenuItem_Click_2);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.graphToolStripMenuItem.Text = "Graph";
            this.graphToolStripMenuItem.Click += new System.EventHandler(this.graphToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.OnHelpClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
           
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sQLConnectionToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // sQLConnectionToolStripMenuItem
            // 
            this.sQLConnectionToolStripMenuItem.Name = "sQLConnectionToolStripMenuItem";
            this.sQLConnectionToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.sQLConnectionToolStripMenuItem.Text = "SQL Connection";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // IMG_BOX_TITLE
            // 
            this.IMG_BOX_TITLE.Image = ((System.Drawing.Image)(resources.GetObject("IMG_BOX_TITLE.Image")));
            this.IMG_BOX_TITLE.Location = new System.Drawing.Point(221, 1);
            this.IMG_BOX_TITLE.Name = "IMG_BOX_TITLE";
            this.IMG_BOX_TITLE.Size = new System.Drawing.Size(465, 83);
            this.IMG_BOX_TITLE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMG_BOX_TITLE.TabIndex = 13;
            this.IMG_BOX_TITLE.TabStop = false;
            // 
            // LBL_CONNECTION
            // 
            this.LBL_CONNECTION.AutoSize = true;
            this.LBL_CONNECTION.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.LBL_CONNECTION.Location = new System.Drawing.Point(319, 90);
            this.LBL_CONNECTION.Name = "LBL_CONNECTION";
            this.LBL_CONNECTION.Size = new System.Drawing.Size(186, 30);
            this.LBL_CONNECTION.TabIndex = 14;
            this.LBL_CONNECTION.Text = "Connection Status:";
            // 
            // LBL_CONNECTION_STATUS
            // 
            this.LBL_CONNECTION_STATUS.AutoSize = true;
            this.LBL_CONNECTION_STATUS.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.LBL_CONNECTION_STATUS.Location = new System.Drawing.Point(499, 91);
            this.LBL_CONNECTION_STATUS.Name = "LBL_CONNECTION_STATUS";
            this.LBL_CONNECTION_STATUS.Size = new System.Drawing.Size(69, 30);
            this.LBL_CONNECTION_STATUS.TabIndex = 15;
            this.LBL_CONNECTION_STATUS.Text = "Status";
            // 
            // BTN_SQL_INFO
            // 
            this.BTN_SQL_INFO.Location = new System.Drawing.Point(552, 125);
            this.BTN_SQL_INFO.Name = "BTN_SQL_INFO";
            this.BTN_SQL_INFO.Size = new System.Drawing.Size(90, 26);
            this.BTN_SQL_INFO.TabIndex = 17;
            this.BTN_SQL_INFO.Text = "SQL Info";
            this.BTN_SQL_INFO.UseVisualStyleBackColor = true;
            this.BTN_SQL_INFO.Click += new System.EventHandler(this.BTN_SQL_INFO_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(700, 402);
            this.Controls.Add(this.BTN_SQL_INFO);
            this.Controls.Add(this.LBL_CONNECTION_STATUS);
            this.Controls.Add(this.LBL_CONNECTION);
            this.Controls.Add(this.IMG_BOX_TITLE);
            this.Controls.Add(this.LBL_GiTHUB);
            this.Controls.Add(this.LINK_LBL_GITHUB);
            this.Controls.Add(this.BTN_ADD);
            this.Controls.Add(this.DATA_GRID);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.DATA_GRID)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_BOX_TITLE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BTN_ADD;
        private LinkLabel LINK_LBL_GITHUB;
        private Label LBL_GiTHUB;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        public  DataGridView DATA_GRID;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private PictureBox IMG_BOX_TITLE;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem sQLConnectionToolStripMenuItem;
        private Label LBL_CONNECTION;
        private Label LBL_CONNECTION_STATUS;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem newToolStripMenuItem1;
        private ToolStripMenuItem addToolStripMenuItem1;
        private ToolStripMenuItem sqlConnectionToolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem1;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private ToolStripMenuItem saveasToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem searchToolStripMenuItem1;
        private Button BTN_SQL_INFO;
        private ToolStripMenuItem editToolStripMenuItem2;
        private ToolStripMenuItem columnsToolStripMenuItem;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Name_;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn RegistrationStatus;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem graphToolStripMenuItem;
        private ToolStripMenuItem dataStyleToolStripMenuItem;
        private ToolStripMenuItem sortToolStripMenuItem;
    }
}