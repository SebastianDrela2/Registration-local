namespace Registration
{
    partial class StyleEditForm
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
            this._listBoxFont = new System.Windows.Forms.ListBox();
            this.LBL_FONT_SIZE = new System.Windows.Forms.Label();
            this._txtboxSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtBoxCellColour = new System.Windows.Forms.TextBox();
            this._txtBoxBackGround = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _listBoxFont
            // 
            this._listBoxFont.FormattingEnabled = true;
            this._listBoxFont.Location = new System.Drawing.Point(1, 3);
            this._listBoxFont.Name = "_listBoxFont";
            this._listBoxFont.Size = new System.Drawing.Size(129, 173);
            this._listBoxFont.TabIndex = 0;
            // 
            // LBL_FONT_SIZE
            // 
            this.LBL_FONT_SIZE.AutoSize = true;
            this.LBL_FONT_SIZE.Location = new System.Drawing.Point(136, 9);
            this.LBL_FONT_SIZE.Name = "LBL_FONT_SIZE";
            this.LBL_FONT_SIZE.Size = new System.Drawing.Size(30, 13);
            this.LBL_FONT_SIZE.TabIndex = 2;
            this.LBL_FONT_SIZE.Text = "Size:";
            // 
            // _txtboxSize
            // 
            this._txtboxSize.Location = new System.Drawing.Point(163, 6);
            this._txtboxSize.Name = "_txtboxSize";
            this._txtboxSize.Size = new System.Drawing.Size(35, 20);
            this._txtboxSize.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "BackGround Color:";
            // 
            // _txtBoxCellColour
            // 
            this._txtBoxCellColour.Location = new System.Drawing.Point(308, 6);
            this._txtBoxCellColour.Name = "_txtBoxCellColour";
            this._txtBoxCellColour.Size = new System.Drawing.Size(35, 20);
            this._txtBoxCellColour.TabIndex = 5;
            this._txtBoxCellColour.Click += new System.EventHandler(this.TXT_BOX_CELL_COLOUR_Click);
            // 
            // _txtBoxBackGround
            // 
            this._txtBoxBackGround.Location = new System.Drawing.Point(419, 6);
            this._txtBoxBackGround.Name = "_txtBoxBackGround";
            this._txtBoxBackGround.Size = new System.Drawing.Size(35, 20);
            this._txtBoxBackGround.TabIndex = 6;
            this._txtBoxBackGround.Click += new System.EventHandler(this.TXT_BOX_BACKGROUND_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cells Color:";
            // 
            // BTN_OK
            // 
            this.BTN_OK.Location = new System.Drawing.Point(568, 146);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(103, 30);
            this.BTN_OK.TabIndex = 8;
            this.BTN_OK.Text = "OK";
            this.BTN_OK.UseVisualStyleBackColor = true;
            this.BTN_OK.Click += new System.EventHandler(this.BTN_OK_Click);
            // 
            // StyleEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 179);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtBoxBackGround);
            this.Controls.Add(this._txtBoxCellColour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtboxSize);
            this.Controls.Add(this.LBL_FONT_SIZE);
            this.Controls.Add(this._listBoxFont);
            this.Name = "StyleEditForm";
            this.Text = "DataStyle";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox _listBoxFont;
        private Label LBL_FONT_SIZE;
        private TextBox _txtboxSize;
        private Label label1;
        private TextBox _txtBoxCellColour;
        private TextBox _txtBoxBackGround;
        private Label label2;
        private Button BTN_OK;
    }
}