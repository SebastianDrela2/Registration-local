namespace Registration
{
    public partial class DatabaseEntry : Form
    {
        public static string path_no_txt { get; set;}
        private MainWindow _mainWindow;

        public DatabaseEntry(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            InitializeComponent();
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            path_no_txt = TXT_BOX_DATA_BASE_NAME.Text;
            var data_base_path = Application.StartupPath + "/Data/" + path_no_txt + ".txt";

            File.Create(data_base_path).Close();
            _mainWindow.DATA_GRID.Rows.Clear();

            _mainWindow.Path = data_base_path;
            Close();
        }

       
    }
}
