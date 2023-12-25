namespace Registration
{
    partial class Sort_Form
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
            this.LIST_BOX_COLUMNS = new System.Windows.Forms.ListBox();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CHCK_BOX_ASCV = new System.Windows.Forms.CheckBox();
            this.CHCK_BOX_DESC = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LIST_BOX_COLUMNS
            // 
            this.LIST_BOX_COLUMNS.FormattingEnabled = true;
            this.LIST_BOX_COLUMNS.Location = new System.Drawing.Point(12, 23);
            this.LIST_BOX_COLUMNS.Name = "LIST_BOX_COLUMNS";
            this.LIST_BOX_COLUMNS.Size = new System.Drawing.Size(120, 134);
            this.LIST_BOX_COLUMNS.TabIndex = 0;
            // 
            // BTN_OK
            // 
            this.BTN_OK.Location = new System.Drawing.Point(141, 113);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(94, 28);
            this.BTN_OK.TabIndex = 1;
            this.BTN_OK.Text = "OK";
            this.BTN_OK.UseVisualStyleBackColor = true;
            this.BTN_OK.Click += new System.EventHandler(this.BTN_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(138, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order By:";
            // 
            // CHCK_BOX_ASCV
            // 
            this.CHCK_BOX_ASCV.AutoSize = true;
            this.CHCK_BOX_ASCV.Location = new System.Drawing.Point(139, 54);
            this.CHCK_BOX_ASCV.Name = "CHCK_BOX_ASCV";
            this.CHCK_BOX_ASCV.Size = new System.Drawing.Size(76, 17);
            this.CHCK_BOX_ASCV.TabIndex = 3;
            this.CHCK_BOX_ASCV.Text = "Ascending";
            this.CHCK_BOX_ASCV.UseVisualStyleBackColor = true;
            this.CHCK_BOX_ASCV.CheckedChanged += new System.EventHandler(this.CHCK_BOX_ASCV_CheckedChanged);
            // 
            // CHCK_BOX_DESC
            // 
            this.CHCK_BOX_DESC.AutoSize = true;
            this.CHCK_BOX_DESC.Location = new System.Drawing.Point(139, 78);
            this.CHCK_BOX_DESC.Name = "CHCK_BOX_DESC";
            this.CHCK_BOX_DESC.Size = new System.Drawing.Size(83, 17);
            this.CHCK_BOX_DESC.TabIndex = 4;
            this.CHCK_BOX_DESC.Text = "Descending";
            this.CHCK_BOX_DESC.UseVisualStyleBackColor = true;
            this.CHCK_BOX_DESC.CheckedChanged += new System.EventHandler(this.CHCK_BOX_DESC_CheckedChanged);
            // 
            // Sort_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 165);
            this.Controls.Add(this.CHCK_BOX_DESC);
            this.Controls.Add(this.CHCK_BOX_ASCV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.LIST_BOX_COLUMNS);
            this.Name = "Sort_Form";
            this.Text = "Sort";
            this.Load += new System.EventHandler(this.Form12_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox LIST_BOX_COLUMNS;
        private Button BTN_OK;
        private Label label1;
        private CheckBox CHCK_BOX_ASCV;
        private CheckBox CHCK_BOX_DESC;
    }
}