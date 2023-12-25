namespace Registration
{
    partial class ColumnEditForm
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
            this.LBL_ADD_COLUMN = new System.Windows.Forms.Label();
            this.TXT_BOX_COLUMN = new System.Windows.Forms.TextBox();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.TXT_BOX_DELETE = new System.Windows.Forms.TextBox();
            this.LBL_DELETE = new System.Windows.Forms.Label();
            this.TXT_BOX_RENAME = new System.Windows.Forms.TextBox();
            this.LBL_RENAME = new System.Windows.Forms.Label();
            this.CHCK_BOX_ADD = new System.Windows.Forms.CheckBox();
            this.CHCK_BOX_DELETE = new System.Windows.Forms.CheckBox();
            this.CHCK_BOX_RENAME = new System.Windows.Forms.CheckBox();
            this.TXT_BOX_FINISH_RENAME = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBL_ADD_COLUMN
            // 
            this.LBL_ADD_COLUMN.AutoSize = true;
            this.LBL_ADD_COLUMN.Location = new System.Drawing.Point(0, 13);
            this.LBL_ADD_COLUMN.Name = "LBL_ADD_COLUMN";
            this.LBL_ADD_COLUMN.Size = new System.Drawing.Size(67, 13);
            this.LBL_ADD_COLUMN.TabIndex = 0;
            this.LBL_ADD_COLUMN.Text = "Add Column:";
            // 
            // TXT_BOX_COLUMN
            // 
            this.TXT_BOX_COLUMN.Location = new System.Drawing.Point(96, 11);
            this.TXT_BOX_COLUMN.Name = "TXT_BOX_COLUMN";
            this.TXT_BOX_COLUMN.Size = new System.Drawing.Size(86, 20);
            this.TXT_BOX_COLUMN.TabIndex = 1;
            // 
            // BTN_OK
            // 
            this.BTN_OK.Location = new System.Drawing.Point(102, 88);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(83, 26);
            this.BTN_OK.TabIndex = 2;
            this.BTN_OK.Text = "OK";
            this.BTN_OK.UseVisualStyleBackColor = true;
            this.BTN_OK.Click += new System.EventHandler(this.BTN_OK_Click);
            // 
            // TXT_BOX_DELETE
            // 
            this.TXT_BOX_DELETE.Location = new System.Drawing.Point(96, 35);
            this.TXT_BOX_DELETE.Name = "TXT_BOX_DELETE";
            this.TXT_BOX_DELETE.Size = new System.Drawing.Size(86, 20);
            this.TXT_BOX_DELETE.TabIndex = 4;
            // 
            // LBL_DELETE
            // 
            this.LBL_DELETE.AutoSize = true;
            this.LBL_DELETE.Location = new System.Drawing.Point(0, 40);
            this.LBL_DELETE.Name = "LBL_DELETE";
            this.LBL_DELETE.Size = new System.Drawing.Size(76, 13);
            this.LBL_DELETE.TabIndex = 3;
            this.LBL_DELETE.Text = "Delete Column";
            // 
            // TXT_BOX_RENAME
            // 
            this.TXT_BOX_RENAME.Location = new System.Drawing.Point(102, 61);
            this.TXT_BOX_RENAME.Name = "TXT_BOX_RENAME";
            this.TXT_BOX_RENAME.Size = new System.Drawing.Size(86, 20);
            this.TXT_BOX_RENAME.TabIndex = 6;
            // 
            // LBL_RENAME
            // 
            this.LBL_RENAME.AutoSize = true;
            this.LBL_RENAME.Location = new System.Drawing.Point(0, 66);
            this.LBL_RENAME.Name = "LBL_RENAME";
            this.LBL_RENAME.Size = new System.Drawing.Size(88, 13);
            this.LBL_RENAME.TabIndex = 5;
            this.LBL_RENAME.Text = "Rename Column:";
            // 
            // CHCK_BOX_ADD
            // 
            this.CHCK_BOX_ADD.AutoSize = true;
            this.CHCK_BOX_ADD.Location = new System.Drawing.Point(72, 14);
            this.CHCK_BOX_ADD.Name = "CHCK_BOX_ADD";
            this.CHCK_BOX_ADD.Size = new System.Drawing.Size(15, 14);
            this.CHCK_BOX_ADD.TabIndex = 7;
            this.CHCK_BOX_ADD.UseVisualStyleBackColor = true;
            this.CHCK_BOX_ADD.CheckedChanged += new System.EventHandler(this.CHCK_BOX_ADD_CheckedChanged);
            // 
            // CHCK_BOX_DELETE
            // 
            this.CHCK_BOX_DELETE.AutoSize = true;
            this.CHCK_BOX_DELETE.Location = new System.Drawing.Point(75, 41);
            this.CHCK_BOX_DELETE.Name = "CHCK_BOX_DELETE";
            this.CHCK_BOX_DELETE.Size = new System.Drawing.Size(15, 14);
            this.CHCK_BOX_DELETE.TabIndex = 8;
            this.CHCK_BOX_DELETE.UseVisualStyleBackColor = true;
            this.CHCK_BOX_DELETE.CheckedChanged += new System.EventHandler(this.CHCK_BOX_DELETE_CheckedChanged);
            // 
            // CHCK_BOX_RENAME
            // 
            this.CHCK_BOX_RENAME.AutoSize = true;
            this.CHCK_BOX_RENAME.Location = new System.Drawing.Point(86, 67);
            this.CHCK_BOX_RENAME.Name = "CHCK_BOX_RENAME";
            this.CHCK_BOX_RENAME.Size = new System.Drawing.Size(15, 14);
            this.CHCK_BOX_RENAME.TabIndex = 9;
            this.CHCK_BOX_RENAME.UseVisualStyleBackColor = true;
            this.CHCK_BOX_RENAME.CheckedChanged += new System.EventHandler(this.CHCK_BOX_RENAME_CheckedChanged);
            // 
            // TXT_BOX_FINISH_RENAME
            // 
            this.TXT_BOX_FINISH_RENAME.Location = new System.Drawing.Point(194, 61);
            this.TXT_BOX_FINISH_RENAME.Name = "TXT_BOX_FINISH_RENAME";
            this.TXT_BOX_FINISH_RENAME.Size = new System.Drawing.Size(86, 20);
            this.TXT_BOX_FINISH_RENAME.TabIndex = 10;
            // 
            // ColumnEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 120);
            this.Controls.Add(this.TXT_BOX_FINISH_RENAME);
            this.Controls.Add(this.CHCK_BOX_RENAME);
            this.Controls.Add(this.CHCK_BOX_DELETE);
            this.Controls.Add(this.CHCK_BOX_ADD);
            this.Controls.Add(this.TXT_BOX_RENAME);
            this.Controls.Add(this.LBL_RENAME);
            this.Controls.Add(this.TXT_BOX_DELETE);
            this.Controls.Add(this.LBL_DELETE);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.TXT_BOX_COLUMN);
            this.Controls.Add(this.LBL_ADD_COLUMN);
            this.Name = "ColumnEditForm";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LBL_ADD_COLUMN;
        private TextBox TXT_BOX_COLUMN;
        private Button BTN_OK;
        private TextBox TXT_BOX_DELETE;
        private Label LBL_DELETE;
        private TextBox TXT_BOX_RENAME;
        private Label LBL_RENAME;
        private CheckBox CHCK_BOX_ADD;
        private CheckBox CHCK_BOX_DELETE;
        private CheckBox CHCK_BOX_RENAME;
        private TextBox TXT_BOX_FINISH_RENAME;
    }
}