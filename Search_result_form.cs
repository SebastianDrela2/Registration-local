using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class Search_result_form : Form
        
    {
    
        public static TextBox txt_box_for_form { get; set; }
          public Search_result_form()
        {
            InitializeComponent();
            txt_box_for_form = TXT_BOX_TEXT1;
        }

        private Rectangle Txt_box_original_rectangle;
        private Rectangle originalFormSize;
        
        private void TXT_BOX_TEXT1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void resizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            
            Txt_box_original_rectangle = new Rectangle(TXT_BOX_TEXT1.Location.X , TXT_BOX_TEXT1.Location.Y , TXT_BOX_TEXT1.Width , TXT_BOX_TEXT1.Height);
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            
            
            
            string result = ""; ;

            TXT_BOX_TEXT1.Text = "Values Found at rows : ";
            TXT_BOX_TEXT1.AppendText(Environment.NewLine);
            TXT_BOX_TEXT1.AppendText(Environment.NewLine);

            foreach (var kpv in SearchForm.dictionary_for_form)
            {
                result = "Row : " + (kpv.Key + 1).ToString() + " " + kpv.Value.ToString();
                TXT_BOX_TEXT1.Text += result;
                TXT_BOX_TEXT1.AppendText(Environment.NewLine);
            }
            
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            TXT_BOX_TEXT1.Text = "";
        }

        private void Form6_Resize(object sender, EventArgs e)
        {
            resizeControl(Txt_box_original_rectangle, TXT_BOX_TEXT1);
        }
    }
}
