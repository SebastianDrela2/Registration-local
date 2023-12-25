namespace Registration
{
    partial class Search_form
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
            this.LBL_Search = new System.Windows.Forms.Label();
            this.TXT_BOX_SEARCH = new System.Windows.Forms.TextBox();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.LBL_COLUMN_NAME = new System.Windows.Forms.Label();
            this.TXT_BOX_COLUMN_NAME = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBL_Search
            // 
            this.LBL_Search.AutoSize = true;
            this.LBL_Search.Location = new System.Drawing.Point(22, 39);
            this.LBL_Search.Name = "LBL_Search";
            this.LBL_Search.Size = new System.Drawing.Size(44, 13);
            this.LBL_Search.TabIndex = 0;
            this.LBL_Search.Text = "Search:";
            // 
            // TXT_BOX_SEARCH
            // 
            this.TXT_BOX_SEARCH.Location = new System.Drawing.Point(66, 36);
            this.TXT_BOX_SEARCH.Name = "TXT_BOX_SEARCH";
            this.TXT_BOX_SEARCH.Size = new System.Drawing.Size(136, 20);
            this.TXT_BOX_SEARCH.TabIndex = 1;
            this.TXT_BOX_SEARCH.TextChanged += new System.EventHandler(this.TXT_BOX_SEARCH_TextChanged);
            // 
            // BTN_OK
            // 
            this.BTN_OK.Location = new System.Drawing.Point(226, 32);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(72, 24);
            this.BTN_OK.TabIndex = 2;
            this.BTN_OK.Text = "OK";
            this.BTN_OK.UseVisualStyleBackColor = true;
            this.BTN_OK.Click += new System.EventHandler(this.BTN_OK_Click);
            // 
            // BTN_Close
            // 
            this.BTN_Close.Location = new System.Drawing.Point(226, 65);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(72, 28);
            this.BTN_Close.TabIndex = 3;
            this.BTN_Close.Text = "Close";
            this.BTN_Close.UseVisualStyleBackColor = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // LBL_COLUMN_NAME
            // 
            this.LBL_COLUMN_NAME.AutoSize = true;
            this.LBL_COLUMN_NAME.Location = new System.Drawing.Point(22, 73);
            this.LBL_COLUMN_NAME.Name = "LBL_COLUMN_NAME";
            this.LBL_COLUMN_NAME.Size = new System.Drawing.Size(73, 13);
            this.LBL_COLUMN_NAME.TabIndex = 4;
            this.LBL_COLUMN_NAME.Text = "Column Name";
            // 
            // TXT_BOX_COLUMN_NAME
            // 
            this.TXT_BOX_COLUMN_NAME.Location = new System.Drawing.Point(100, 70);
            this.TXT_BOX_COLUMN_NAME.Name = "TXT_BOX_COLUMN_NAME";
            this.TXT_BOX_COLUMN_NAME.Size = new System.Drawing.Size(86, 20);
            this.TXT_BOX_COLUMN_NAME.TabIndex = 5;
            // 
            // Search_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 119);
            this.Controls.Add(this.TXT_BOX_COLUMN_NAME);
            this.Controls.Add(this.LBL_COLUMN_NAME);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.TXT_BOX_SEARCH);
            this.Controls.Add(this.LBL_Search);
            this.Name = "Search_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LBL_Search;
        private TextBox TXT_BOX_SEARCH;
        private Button BTN_OK;
        private Button BTN_Close;
        private Label LBL_COLUMN_NAME;
        private TextBox TXT_BOX_COLUMN_NAME;
    }
}