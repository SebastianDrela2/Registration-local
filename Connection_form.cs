using System.Data;
using System.Data.SqlClient;

namespace Registration
{
    public partial class ConnectionForm : Form
    {
        public static bool SqlChecker { get; set; }
        public string ConnectionString { get; set; }

        public static SqlConnection con { get; set; }
        public static string DataTable { get; set;}
        public static List<int> IdList = new List<int>();
        public static List<List<string>> ListaString = new List<List<string>>();

        private static DataGridView _dataGridView;

        public ConnectionForm(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;

            InitializeComponent();
        }


        public static void ColumnRemover(int field_count)
        {
            var count = _dataGridView.Columns.Count;
            var operation_result = count - field_count;
            count -= 1;

            for (var i = 0; i < operation_result; i++)
            {
                _dataGridView.Columns.RemoveAt(count - i);
            }

        }
        public static void DisplayData()
        {
            using SqlCommand cmd = new SqlCommand
            {
                Connection = con,
                CommandType = CommandType.Text,
                CommandText = "SELECT * FROM " + DataTable
            };

            con.Open();
            using SqlDataReader sqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            ColumnRemover(sqlDataReader.FieldCount);
            while (sqlDataReader.Read())
            {
                IdList.Add(Int32.Parse(sqlDataReader[0].ToString()));

                for (int m = 0; m < MainWindow.ResultColumn - 1; m++)
                {
                    ListaString[m].Add(sqlDataReader[m + 1].ToString());
                }

                _dataGridView.ClearSelection();
            }
            _dataGridView.Rows.Clear();
            con.Close();
            for (var i = 0; i < IdList.Count; i++)
            {
                _dataGridView.Rows.Add();
                _dataGridView.ClearSelection();
            }

            for (int j = 0; j < IdList.Count; j++)
            {
                _dataGridView.Rows[j].Cells[0].Value = IdList[j];

                for (int p = 0; p < MainWindow.ResultColumn - 1; p++)
                {
                    var list = ListaString[p];
                    Console.WriteLine(list[j]);
                    _dataGridView.Rows[j].Cells[p + 1].Value = list[j];
                }

                _dataGridView.ClearSelection();
            }

            _dataGridView.ClearSelection();
        }

        public void BTN_OK_Click(object sender, EventArgs e)
        {
            BTN_PROCEED.Enabled = true;
            ConnectionString = TXT_BOT_CONNECTION.Text;
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

        private void BTN_PROCEED_Click(object sender, EventArgs e)
        {
            string column_name;
            for (int s = 1; s < _dataGridView.Columns.Count; s++)
            {
                column_name = _dataGridView.Columns[s].Name;
                _dataGridView.Columns.Remove(column_name);
            }
            DataTable =  LIST_BOX_DT.SelectedItem.ToString(); 
            MainWindow.RuntimeChecker = true;
            MainWindow.Label2.Text = "O N L I N E";
            MainWindow.Label2.ForeColor = Color.Green;
           
            
            MainWindow.SqlInfoForForm.Enabled = true;
            _dataGridView.ClearSelection();

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand()
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = "SELECT count(*) FROM information_schema.columns WHERE table_name = '"+DataTable+"'"
            };

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    MainWindow.ResultColumn = reader.GetInt32(0);
                    _dataGridView.ClearSelection();
                }
            }
            connection.Close();
            _dataGridView.ClearSelection();

            for (var o = 0; o < MainWindow.ResultColumn - 1; o++)
            {
                ListaString.Add(new List<string>());
            }

            con = new SqlConnection(ConnectionString);
            con.Open();

            using SqlCommand cmd2 = new SqlCommand
            {
                Connection = con,
                CommandType = CommandType.Text,
                CommandText = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + DataTable + "'"
            };
            _dataGridView.ClearSelection();
            var sqldatareader2 = cmd2.ExecuteReader();
            var list_results = new List<string>();
            while (sqldatareader2.Read())
            {
                list_results.Add(sqldatareader2[0].ToString());
                _dataGridView.ClearSelection();
            }

            _dataGridView.ClearSelection();
            _dataGridView.ClearSelection();
            _dataGridView.ClearSelection();

            ColumnRemover(MainWindow.ResultColumn);
            _dataGridView.ClearSelection();

            for (var k = 1; k < MainWindow.ResultColumn; k++)
            {
                _dataGridView.Columns.Add(list_results[k] + "_" , list_results[k]);
                _dataGridView.Columns[k].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            con.Close();

            _dataGridView.ClearSelection();
            DisplayData();
            Close();
        }
    }
}
