namespace Registration
{
    partial class Search_result_form
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
            this.TXT_BOX_TEXT = new System.Windows.Forms.TextBox();
            this.TXT_BOX_TEXT1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TXT_BOX_TEXT
            // 
            this.TXT_BOX_TEXT.Location = new System.Drawing.Point(-2, -1);
            this.TXT_BOX_TEXT.Multiline = true;
            this.TXT_BOX_TEXT.Name = "TXT_BOX_TEXT";
            this.TXT_BOX_TEXT.Size = new System.Drawing.Size(377, 169);
            this.TXT_BOX_TEXT.TabIndex = 0;
            // 
            // TXT_BOX_TEXT1
            // 
            this.TXT_BOX_TEXT1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_BOX_TEXT1.Location = new System.Drawing.Point(-3, -1);
            this.TXT_BOX_TEXT1.Multiline = true;
            this.TXT_BOX_TEXT1.Name = "TXT_BOX_TEXT1";
            this.TXT_BOX_TEXT1.Size = new System.Drawing.Size(400, 200);
            this.TXT_BOX_TEXT1.TabIndex = 0;
            this.TXT_BOX_TEXT1.TextChanged += new System.EventHandler(this.TXT_BOX_TEXT1_TextChanged);
            // 
            // Form6
            // 
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.TXT_BOX_TEXT1);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form6_FormClosing);
            this.Load += new System.EventHandler(this.Form6_Load);
            this.Resize += new System.EventHandler(this.Form6_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TXT_BOX_TEXT;
        private TextBox TXT_BOX_TEXT1;
    }
}