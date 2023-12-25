namespace Registration
{
    partial class Test_form
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
            this.testbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // testbox
            // 
            this.testbox.Location = new System.Drawing.Point(37, 120);
            this.testbox.Name = "testbox";
            this.testbox.Size = new System.Drawing.Size(100, 23);
            this.testbox.TabIndex = 0;
            // 
            // Form7
            // 
            this.ClientSize = new System.Drawing.Size(478, 360);
            this.Name = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox testbox;
    }
}