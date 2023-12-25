using System.Drawing.Text;

namespace Registration
{
    public partial class StyleEdit_Form : Form
    {
        public StyleEdit_Form()
        {
            InitializeComponent();
        }

        private void SettingData()
        {
            UserInput.DataGridView.Font = new Font(LIST_BOX_FONT.SelectedItem.ToString(), float.Parse(TXT_BOX_SIZE.Text));
            UserInput.DataGridView.BackgroundColor = TXT_BOX_CELL_COLOUR.BackColor;
            UserInput.DataGridView.ForeColor = TXT_BOX_BACKGROUND.BackColor;

            var FC_ARGB = TXT_BOX_BACKGROUND.BackColor;
            var FC = $"{FC_ARGB.A},{FC_ARGB.R},{FC_ARGB.G},{FC_ARGB.B}";

            Color FB_ARGB = TXT_BOX_CELL_COLOUR.BackColor;
            var FB = $"{FB_ARGB.A},{FB_ARGB.R},{FB_ARGB.G},{FB_ARGB.B}";

            var settings = new List<string>();
            settings.Add(LIST_BOX_FONT.SelectedItem.ToString());
            settings.Add(TXT_BOX_SIZE.Text);
            settings.Add(FC);
            settings.Add(FB);
            
            File.WriteAllLines(MainWindow.FontData, settings);
        }
        private void Form11_Load(object sender, EventArgs e)
        {

            TXT_BOX_SIZE.Text = UserInput.DataGridView.Font.Size.ToString();
            InstalledFontCollection collection = new InstalledFontCollection();
            foreach (FontFamily FA in collection.Families)
            {
                LIST_BOX_FONT.Items.Add(FA.Name);
            }
            foreach (var item in LIST_BOX_FONT.Items)
            {
                if (item.ToString() == UserInput.DataGridView.Font.Name)
                {
                    LIST_BOX_FONT.SelectedItem = item;
                }
            }

            TXT_BOX_BACKGROUND.ForeColor = UserInput.DataGridView.ForeColor;
            TXT_BOX_CELL_COLOUR.BackColor = UserInput.DataGridView.BackgroundColor;
            
        }

        private void TXT_BOX_CELL_COLOUR_Click(object sender, EventArgs e)
        {

            var colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            colorDialog.ShowHelp = true;
            TXT_BOX_CELL_COLOUR.BackColor = colorDialog.Color;
            
        }

        private void TXT_BOX_BACKGROUND_Click(object sender, EventArgs e)
        {

            var colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            colorDialog.ShowHelp = true;
            TXT_BOX_BACKGROUND.BackColor = colorDialog.Color;
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
          SettingData();
        }
    }
}
