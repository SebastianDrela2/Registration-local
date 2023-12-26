using System.Drawing.Text;

namespace Registration
{
    public partial class StyleEditForm : Form
    {
        private readonly DataGridView _dataGridView;
        private readonly MainWindow _mainWindow;

        public StyleEditForm(MainWindow mainWindow)
        {
            _dataGridView = mainWindow.DataGrid;
            _mainWindow = mainWindow;

            InitializeComponent();
        }

        private void SettingData()
        {
            _dataGridView.Font = new Font(_listBoxFont.SelectedItem.ToString(), float.Parse(_txtboxSize.Text));
            _dataGridView.BackgroundColor = _txtBoxCellColour.BackColor;
            _dataGridView.ForeColor = _txtBoxBackGround.BackColor;

            var FC_ARGB = _txtBoxBackGround.BackColor;
            var FC = $"{FC_ARGB.A},{FC_ARGB.R},{FC_ARGB.G},{FC_ARGB.B}";

            Color FB_ARGB = _txtBoxCellColour.BackColor;
            var FB = $"{FB_ARGB.A},{FB_ARGB.R},{FB_ARGB.G},{FB_ARGB.B}";

            var settings = new List<string>();
            settings.Add(_listBoxFont.SelectedItem.ToString());
            settings.Add(_txtboxSize.Text);
            settings.Add(FC);
            settings.Add(FB);
            
            File.WriteAllLines(_mainWindow.FontData, settings);
        }
        private void OnLoad(object sender, EventArgs e)
        {
            _txtboxSize.Text = _dataGridView.Font.Size.ToString();
            var collection = new InstalledFontCollection();
            foreach (FontFamily FA in collection.Families)
            {
                _listBoxFont.Items.Add(FA.Name);
            }

            foreach (var item in _listBoxFont.Items)
            {
                if (item.ToString() == _dataGridView.Font.Name)
                {
                    _listBoxFont.SelectedItem = item;
                    break;
                }
            }

            _txtBoxBackGround.ForeColor = _dataGridView.ForeColor;
            _txtBoxCellColour.BackColor = _dataGridView.BackgroundColor;
        }

        private void TXT_BOX_CELL_COLOUR_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            colorDialog.ShowHelp = true;
            _txtBoxCellColour.BackColor = colorDialog.Color;
            
        }

        private void TXT_BOX_BACKGROUND_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            colorDialog.ShowHelp = true;
            _txtBoxBackGround.BackColor = colorDialog.Color;
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
           SettingData();
           Close();
        }
    }
}
