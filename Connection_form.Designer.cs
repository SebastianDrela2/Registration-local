namespace Registration
{
    partial class Connection_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_BOT_CONNECTION = new System.Windows.Forms.TextBox();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.LIST_BOX_DT = new System.Windows.Forms.ListBox();
            this.BTN_PROCEED = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection String:";
            // 
            // TXT_BOT_CONNECTION
            // 
            this.TXT_BOT_CONNECTION.Location = new System.Drawing.Point(106, 15);
            this.TXT_BOT_CONNECTION.Name = "TXT_BOT_CONNECTION";
            this.TXT_BOT_CONNECTION.Size = new System.Drawing.Size(165, 20);
            this.TXT_BOT_CONNECTION.TabIndex = 1;
            // 
            // BTN_OK
            // 
            this.BTN_OK.Location = new System.Drawing.Point(160, 51);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(76, 23);
            this.BTN_OK.TabIndex = 2;
            this.BTN_OK.Text = "Connect";
            this.BTN_OK.UseVisualStyleBackColor = true;
            this.BTN_OK.Click += new System.EventHandler(this.BTN_OK_Click);
            // 
            // LIST_BOX_DT
            // 
            this.LIST_BOX_DT.FormattingEnabled = true;
            this.LIST_BOX_DT.Location = new System.Drawing.Point(25, 42);
            this.LIST_BOX_DT.Name = "LIST_BOX_DT";
            this.LIST_BOX_DT.Size = new System.Drawing.Size(103, 95);
            this.LIST_BOX_DT.TabIndex = 3;
           
            // 
            // BTN_PROCEED
            // 
            this.BTN_PROCEED.Enabled = false;
            this.BTN_PROCEED.Location = new System.Drawing.Point(160, 98);
            this.BTN_PROCEED.Name = "BTN_PROCEED";
            this.BTN_PROCEED.Size = new System.Drawing.Size(76, 24);
            this.BTN_PROCEED.TabIndex = 4;
            this.BTN_PROCEED.Text = "OK";
            this.BTN_PROCEED.UseVisualStyleBackColor = true;
            this.BTN_PROCEED.Click += new System.EventHandler(this.BTN_PROCEED_Click);
            // 
            // Connection_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 139);
            this.Controls.Add(this.BTN_PROCEED);
            this.Controls.Add(this.LIST_BOX_DT);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.TXT_BOT_CONNECTION);
            this.Controls.Add(this.label1);
            this.Name = "Connection_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TXT_BOT_CONNECTION;
        private Button BTN_OK;
        private ListBox LIST_BOX_DT;
        private Button BTN_PROCEED;
    }
}