using System.Data;
using System.Data.SqlClient;

namespace Registration
{
    public partial class ConnectionForm : Form
    {
        public static bool SqlChecker { get; set; }
        public string ConnectionString { get; set; }

        public static SqlConnection? CurrentConnection { get; set; }
        public static string DataTable { get; set;}
        public static List<int> IdList = new List<int>();
        public static List<List<string>> ListaString = new List<List<string>>();

        private static DataGridView _dataGridView;
        private readonly MainWindow _mainWindow;
        public ConnectionForm(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            _dataGridView = mainWindow.DataGrid;

            InitializeComponent();
        }

        public void RemoveColumns(int field_count)
        {
            var count = _dataGridView.Columns.Count;
            var operationResult = count - field_count;
            count -= 1;

            for (var i = 0; i < operationResult; i++)
            {
                _dataGridView.Columns.RemoveAt(count - i);
            }

        }

        public void DisplayData()
        {
            using var cmd = new SqlCommand
            {
                Connection = CurrentConnection,
                CommandType = CommandType.Text,
                CommandText = "SELECT * FROM " + DataTable
            };

            CurrentConnection.Open();
            using SqlDataReader sqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            RemoveColumns(sqlDataReader.FieldCount);
            while (sqlDataReader.Read())
            {
                IdList.Add(int.Parse(sqlDataReader[0].ToString()));

                for (var m = 0; m < _mainWindow.ResultColumn - 1; m++)
                {
                    ListaString[m].Add(sqlDataReader[m + 1].ToString());
                }

                _dataGridView.ClearSelection();
            }
            _dataGridView.Rows.Clear();
            CurrentConnection.Close();
            for (var i = 0; i < IdList.Count; i++)
            {
                _dataGridView.Rows.Add();
                _dataGridView.ClearSelection();
            }

            for (var j = 0; j < IdList.Count; j++)
            {
                _dataGridView.Rows[j].Cells[0].Value = IdList[j];

                for (int p = 0; p < _mainWindow.ResultColumn - 1; p++)
                {
                    var list = ListaString[p];
                    Console.WriteLine(list[j]);
                    _dataGridView.Rows[j].Cells[p + 1].Value = list[j];
                }

                _dataGridView.ClearSelection();
            }

            _dataGridView.ClearSelection();
        }

        public void OnOkClicked(object sender, EventArgs e)
        {
            _buttonProceed.Enabled = true;
            ConnectionString = _textBoxConnection.Text;
            var connectionForwardData = new SqlConnection(ConnectionString);
            connectionForwardData.Open();

            var commandForwardData = new SqlCommand()
            {
                Connection = connectionForwardData,
                CommandType = CommandType.Text,
                CommandText = "SELECT name FROM sys.tables"
            };

            var reader = commandForwardData.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    LIST_BOX_DT.Items.Add(reader[i]);
                }
            }

            connectionForwardData.Close();
        }

        private void OnProceedClicked(object sender, EventArgs e)
        {
            string column_name;
            for (var s = 1; s < _dataGridView.Columns.Count; s++)
            {
                column_name = _dataGridView.Columns[s].Name;
                _dataGridView.Columns.Remove(column_name);
            }
            DataTable =  LIST_BOX_DT.SelectedItem.ToString();
            _mainWindow.RuntimeChecker = true;
            _mainWindow.OnlineLabelStatus.Text = "O N L I N E";
            _mainWindow.OnlineLabelStatus.ForeColor = Color.Green;

            _mainWindow.Enabled = true;
            _dataGridView.ClearSelection();

            var connection = new SqlConnection(ConnectionString);
            connection.Open();
            var command = new SqlCommand()
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = "SELECT count(*) FROM information_schema.columns WHERE table_name = '"+DataTable+"'"
            };

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    _mainWindow.ResultColumn = reader.GetInt32(0);
                    _dataGridView.ClearSelection();
                }
            }
            connection.Close();
            _dataGridView.ClearSelection();

            for (var o = 0; o < _mainWindow.ResultColumn - 1; o++)
            {
                ListaString.Add(new List<string>());
            }

            CurrentConnection = new SqlConnection(ConnectionString);
            CurrentConnection.Open();

            using var cmd2 = new SqlCommand
            {
                Connection = CurrentConnection,
                CommandType = CommandType.Text,
                CommandText = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + DataTable + "'"
            };
            _dataGridView.ClearSelection();
            var sqldatareader2 = cmd2.ExecuteReader();
            var listResults = new List<string>();
            while (sqldatareader2.Read())
            {
                listResults.Add(sqldatareader2[0].ToString());
                _dataGridView.ClearSelection();
            }

            _dataGridView.ClearSelection();
            _dataGridView.ClearSelection();
            _dataGridView.ClearSelection();

            RemoveColumns(_mainWindow.ResultColumn);
            _dataGridView.ClearSelection();

            for (var k = 1; k < _mainWindow.ResultColumn; k++)
            {
                _dataGridView.Columns.Add(listResults[k] + "_" , listResults[k]);
                _dataGridView.Columns[k].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            CurrentConnection.Close();

            _dataGridView.ClearSelection();
            DisplayData();
            Close();
        }
    }
}
