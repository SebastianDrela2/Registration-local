namespace Registration
{
    partial class ConnectionForm
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
            this._labelConnectionPrefix = new System.Windows.Forms.Label();
            this._textBoxConnection = new System.Windows.Forms.TextBox();
            this._buttonOk = new System.Windows.Forms.Button();
            this.LIST_BOX_DT = new System.Windows.Forms.ListBox();
            this._buttonProceed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _labelConnectionPrefix
            // 
            this._labelConnectionPrefix.AutoSize = true;
            this._labelConnectionPrefix.Location = new System.Drawing.Point(10, 17);
            this._labelConnectionPrefix.Name = "_labelConnectionPrefix";
            this._labelConnectionPrefix.Size = new System.Drawing.Size(94, 13);
            this._labelConnectionPrefix.TabIndex = 0;
            this._labelConnectionPrefix.Text = "Connection String:";
            // 
            // _textBoxConnection
            // 
            this._textBoxConnection.Location = new System.Drawing.Point(106, 15);
            this._textBoxConnection.Name = "_textBoxConnection";
            this._textBoxConnection.Size = new System.Drawing.Size(165, 20);
            this._textBoxConnection.TabIndex = 1;
            // 
            // _buttonOk
            // 
            this._buttonOk.Location = new System.Drawing.Point(160, 51);
            this._buttonOk.Name = "_buttonOk";
            this._buttonOk.Size = new System.Drawing.Size(76, 23);
            this._buttonOk.TabIndex = 2;
            this._buttonOk.Text = "Connect";
            this._buttonOk.UseVisualStyleBackColor = true;
            this._buttonOk.Click += new System.EventHandler(this.OnOkClicked);
            // 
            // LIST_BOX_DT
            // 
            this.LIST_BOX_DT.FormattingEnabled = true;
            this.LIST_BOX_DT.Location = new System.Drawing.Point(25, 42);
            this.LIST_BOX_DT.Name = "LIST_BOX_DT";
            this.LIST_BOX_DT.Size = new System.Drawing.Size(103, 95);
            this.LIST_BOX_DT.TabIndex = 3;
           
            // 
            // _buttonProceed
            // 
            this._buttonProceed.Enabled = false;
            this._buttonProceed.Location = new System.Drawing.Point(160, 98);
            this._buttonProceed.Name = "_buttonProceed";
            this._buttonProceed.Size = new System.Drawing.Size(76, 24);
            this._buttonProceed.TabIndex = 4;
            this._buttonProceed.Text = "OK";
            this._buttonProceed.UseVisualStyleBackColor = true;
            this._buttonProceed.Click += new System.EventHandler(this.OnProceedClicked);
            // 
            // _connectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 139);
            this.Controls.Add(this._buttonProceed);
            this.Controls.Add(this.LIST_BOX_DT);
            this.Controls.Add(this._buttonOk);
            this.Controls.Add(this._textBoxConnection);
            this.Controls.Add(this._labelConnectionPrefix);
            this.Name = "ConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _labelConnectionPrefix;
        private TextBox _textBoxConnection;
        private Button _buttonOk;
        private ListBox LIST_BOX_DT;
        private Button _buttonProceed;
    }
}