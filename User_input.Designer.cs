namespace Registration
{
    partial class UserInput
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
            this.TXT_BOX_SURNAME2 = new System.Windows.Forms.TextBox();
            this.TXT_BOX_NAME2 = new System.Windows.Forms.TextBox();
            this.LBL_SURNAME = new System.Windows.Forms.Label();
            this.LBL_NAME = new System.Windows.Forms.Label();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.CHCK_BOX_YES = new System.Windows.Forms.CheckBox();
            this.CHCK_BOX_NO = new System.Windows.Forms.CheckBox();
            this.LBL_REGISTRATION = new System.Windows.Forms.Label();
            this.BTN_FORM2_CLOSE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXT_BOX_SURNAME2
            // 
            this.TXT_BOX_SURNAME2.Location = new System.Drawing.Point(111, 85);
            this.TXT_BOX_SURNAME2.Name = "TXT_BOX_SURNAME2";
            this.TXT_BOX_SURNAME2.Size = new System.Drawing.Size(86, 20);
            this.TXT_BOX_SURNAME2.TabIndex = 11;
            // 
            // TXT_BOX_NAME2
            // 
            this.TXT_BOX_NAME2.Location = new System.Drawing.Point(111, 60);
            this.TXT_BOX_NAME2.Name = "TXT_BOX_NAME2";
            this.TXT_BOX_NAME2.Size = new System.Drawing.Size(86, 20);
            this.TXT_BOX_NAME2.TabIndex = 10;
            // 
            // LBL_SURNAME
            // 
            this.LBL_SURNAME.AutoSize = true;
            this.LBL_SURNAME.Location = new System.Drawing.Point(36, 88);
            this.LBL_SURNAME.Name = "LBL_SURNAME";
            this.LBL_SURNAME.Size = new System.Drawing.Size(64, 13);
            this.LBL_SURNAME.TabIndex = 9;
            this.LBL_SURNAME.Text = "SURNAME:";
            // 
            // LBL_NAME
            // 
            this.LBL_NAME.AutoSize = true;
            this.LBL_NAME.Location = new System.Drawing.Point(54, 62);
            this.LBL_NAME.Name = "LBL_NAME";
            this.LBL_NAME.Size = new System.Drawing.Size(41, 13);
            this.LBL_NAME.TabIndex = 8;
            this.LBL_NAME.Text = "NAME:";
            // 
            // BTN_OK
            // 
            this.BTN_OK.Location = new System.Drawing.Point(63, 132);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(86, 27);
            this.BTN_OK.TabIndex = 14;
            this.BTN_OK.Text = "OK";
            this.BTN_OK.UseVisualStyleBackColor = true;
            this.BTN_OK.Click += new System.EventHandler(this.OnOkClicked);
            // 
            // CHCK_BOX_YES
            // 
            this.CHCK_BOX_YES.AutoSize = true;
            this.CHCK_BOX_YES.Location = new System.Drawing.Point(122, 110);
            this.CHCK_BOX_YES.Name = "CHCK_BOX_YES";
            this.CHCK_BOX_YES.Size = new System.Drawing.Size(44, 17);
            this.CHCK_BOX_YES.TabIndex = 15;
            this.CHCK_BOX_YES.Text = "Yes";
            this.CHCK_BOX_YES.UseVisualStyleBackColor = true;
            this.CHCK_BOX_YES.CheckedChanged += new System.EventHandler(this.CHCK_BOX_YES_CheckedChanged);
            // 
            // CHCK_BOX_NO
            // 
            this.CHCK_BOX_NO.AutoSize = true;
            this.CHCK_BOX_NO.Location = new System.Drawing.Point(172, 110);
            this.CHCK_BOX_NO.Name = "CHCK_BOX_NO";
            this.CHCK_BOX_NO.Size = new System.Drawing.Size(40, 17);
            this.CHCK_BOX_NO.TabIndex = 16;
            this.CHCK_BOX_NO.Text = "No";
            this.CHCK_BOX_NO.UseVisualStyleBackColor = true;
            this.CHCK_BOX_NO.CheckedChanged += new System.EventHandler(this.CHCK_BOX_NO_CheckedChanged);
            // 
            // LBL_REGISTRATION
            // 
            this.LBL_REGISTRATION.AutoSize = true;
            this.LBL_REGISTRATION.Location = new System.Drawing.Point(31, 111);
            this.LBL_REGISTRATION.Name = "LBL_REGISTRATION";
            this.LBL_REGISTRATION.Size = new System.Drawing.Size(73, 13);
            this.LBL_REGISTRATION.TabIndex = 17;
            this.LBL_REGISTRATION.Text = "REGISTRED:";
            // 
            // BTN_FORM2_CLOSE
            // 
            this.BTN_FORM2_CLOSE.Location = new System.Drawing.Point(163, 132);
            this.BTN_FORM2_CLOSE.Name = "BTN_FORM2_CLOSE";
            this.BTN_FORM2_CLOSE.Size = new System.Drawing.Size(85, 27);
            this.BTN_FORM2_CLOSE.TabIndex = 18;
            this.BTN_FORM2_CLOSE.Text = "Close";
            this.BTN_FORM2_CLOSE.UseVisualStyleBackColor = true;
           
            // 
            // UserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(298, 162);
            this.Controls.Add(this.BTN_FORM2_CLOSE);
            this.Controls.Add(this.LBL_REGISTRATION);
            this.Controls.Add(this.CHCK_BOX_NO);
            this.Controls.Add(this.CHCK_BOX_YES);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.TXT_BOX_SURNAME2);
            this.Controls.Add(this.TXT_BOX_NAME2);
            this.Controls.Add(this.LBL_SURNAME);
            this.Controls.Add(this.LBL_NAME);
            this.Name = "UserInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD";
            
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox TXT_BOX_SURNAME2;
        private TextBox TXT_BOX_NAME2;
        private Label LBL_SURNAME;
        private Label LBL_NAME;
        private Button BTN_OK;
        private CheckBox CHCK_BOX_YES;
        private CheckBox CHCK_BOX_NO;
        private Label LBL_REGISTRATION;
        private Button BTN_FORM2_CLOSE;
    }
}