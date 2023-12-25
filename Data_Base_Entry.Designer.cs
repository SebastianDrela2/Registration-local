namespace Registration
{
    partial class DatabaseEntry
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
            this.LBL_NAME = new System.Windows.Forms.Label();
            this.TXT_BOX_DATA_BASE_NAME = new System.Windows.Forms.TextBox();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_NAME
            // 
            this.LBL_NAME.AutoSize = true;
            this.LBL_NAME.Location = new System.Drawing.Point(1, 18);
            this.LBL_NAME.Name = "LBL_NAME";
            this.LBL_NAME.Size = new System.Drawing.Size(101, 13);
            this.LBL_NAME.TabIndex = 0;
            this.LBL_NAME.Text = "DATABASE NAME:";
            // 
            // TXT_BOX_DATA_BASE_NAME
            // 
            this.TXT_BOX_DATA_BASE_NAME.Location = new System.Drawing.Point(97, 15);
            this.TXT_BOX_DATA_BASE_NAME.Name = "TXT_BOX_DATA_BASE_NAME";
            this.TXT_BOX_DATA_BASE_NAME.Size = new System.Drawing.Size(86, 20);
            this.TXT_BOX_DATA_BASE_NAME.TabIndex = 1;
            // 
            // BTN_OK
            // 
            this.BTN_OK.Location = new System.Drawing.Point(57, 40);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(76, 27);
            this.BTN_OK.TabIndex = 2;
            this.BTN_OK.Text = "OK";
            this.BTN_OK.UseVisualStyleBackColor = true;
            this.BTN_OK.Click += new System.EventHandler(this.BTN_OK_Click);
            // 
            // DatabaseEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 70);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.TXT_BOX_DATA_BASE_NAME);
            this.Controls.Add(this.LBL_NAME);
            this.Name = "DatabaseEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LBL_NAME;
        private TextBox TXT_BOX_DATA_BASE_NAME;
        private Button BTN_OK;
    }
}