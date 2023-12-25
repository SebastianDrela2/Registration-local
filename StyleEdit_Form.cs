using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Registration
{
    public partial class StyleEdit_Form : Form
    {
        public static List<string> settings = new List<string>();
        public StyleEdit_Form()
        {
            InitializeComponent();
        }

        private void SettingData()
        {
            User_input.Dvg.Font = new Font(LIST_BOX_FONT.SelectedItem.ToString(), float.Parse(TXT_BOX_SIZE.Text));
            User_input.Dvg.BackgroundColor = TXT_BOX_CELL_COLOUR.BackColor;
            User_input.Dvg.ForeColor = TXT_BOX_BACKGROUND.BackColor;

           
            
            
            
            Color FC_ARGB = TXT_BOX_BACKGROUND.BackColor;
            string FC = $"{FC_ARGB.A},{FC_ARGB.R},{FC_ARGB.G},{FC_ARGB.B}";

            Color FB_ARGB = TXT_BOX_CELL_COLOUR.BackColor;
            string FB = $"{FB_ARGB.A},{FB_ARGB.R},{FB_ARGB.G},{FB_ARGB.B}";

            List<string> settings = new List<string>();
            settings.Add(LIST_BOX_FONT.SelectedItem.ToString());
            settings.Add(TXT_BOX_SIZE.Text);
            settings.Add(FC);
            settings.Add(FB);
            




            
            File.WriteAllLines(Main_window.font_data, settings);
        }
        private void Form11_Load(object sender, EventArgs e)
        {

            TXT_BOX_SIZE.Text = User_input.Dvg.Font.Size.ToString();
            InstalledFontCollection collection = new InstalledFontCollection();
            foreach (FontFamily FA in collection.Families)
            {
                LIST_BOX_FONT.Items.Add(FA.Name);
            }
            for (int i = 0; i < LIST_BOX_FONT.Items.Count; i++)
            {
                if (LIST_BOX_FONT.Items[i].ToString() == User_input.Dvg.Font.Name)
                {
                    LIST_BOX_FONT.SelectedItem = LIST_BOX_FONT.Items[i];
                }
            }

            TXT_BOX_BACKGROUND.ForeColor = User_input.Dvg.ForeColor;
            TXT_BOX_CELL_COLOUR.BackColor = User_input.Dvg.BackgroundColor;
            
        }

        

        private void TXT_BOX_CELL_COLOUR_Clicked(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            color.ShowHelp = true;
            TXT_BOX_CELL_COLOUR.ForeColor = color.Color;
        }

        private void TXT_BOX_CELL_COLOUR_Click(object sender, EventArgs e)
        {

            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            color.ShowHelp = true;
            TXT_BOX_CELL_COLOUR.BackColor = color.Color;
            
        }

        private void TXT_BOX_BACKGROUND_Click(object sender, EventArgs e)
        {

            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            color.ShowHelp = true;
            TXT_BOX_BACKGROUND.BackColor = color.Color;
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
          SettingData();
        }

        private void LIST_BOX_FONT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
