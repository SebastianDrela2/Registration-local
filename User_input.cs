using System.Data;
using System.Data.SqlClient;

namespace Registration
{
    public partial class UserInput : Form
    {
        public DataGridView DataGridView { get; set; }

        public List<TextBox> TxtBoxList = new List<TextBox>();

        public static int id_count;

        private readonly MainWindow _mainWindow;
        private readonly ConnectionForm _connectionForm;
        public UserInput(MainWindow mainWindow, ConnectionForm connectionForm)
        {
            _mainWindow = mainWindow;
            _connectionForm = connectionForm;

            InitializeComponent();
            TXT_BOX_NAME2.Visible = false;
            TXT_BOX_SURNAME2.Visible = false;
            CHCK_BOX_NO.Visible = false;
            CHCK_BOX_YES.Visible = false;
            
            LBL_NAME.Visible = false;
            LBL_REGISTRATION.Visible = false;
            LBL_SURNAME.Visible = false;

            var posx = 100;
            var posy = 15;
            
            TxtBoxList.Clear();
            
            var labelList = new List<Label>();
            for (int i = 1; i < DataGridView.Columns.Count; i++)
            {
                TxtBoxList.Add(new TextBox());
                labelList.Add(new Label());

                var txtbox = TxtBoxList[i - 1];
                var label = labelList[i - 1];

                txtbox.Location = new Point(posx - 40, posy);
                Controls.Add(txtbox);

                label.Location = new Point(posx - 100, posy);
                label.Text = DataGridView.Columns[i].HeaderText + @":";
                Controls.Add(label);

                posy += 36;
            }

            BTN_OK.Location = new Point(62, posy + 30);
            BTN_FORM2_CLOSE.Location = new Point(183, posy + 30);
        }
        
        public static List<string> entire_data = new List<string>();

        private void OnOkClicked(object sender, EventArgs e)
        {
            DataGridView.Rows.Add();
           
            if (_mainWindow.Label2.ForeColor == Color.Green)
            {
                var result = "INSERT INTO UserData VALUES (";
                for (var s = 0; s < _mainWindow.ResultColumn - 1; s++)
                {
                    result += "'" + TxtBoxList[s].Text + "'";
                    if (s != _mainWindow.ResultColumn - 2)
                    {
                        result += " ,";
                    }
                }
                result += ")";

                var connection = new SqlConnection(_connectionForm.ConnectionString);
                connection.Open();
                var command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = result
                     
                };
                command.ExecuteNonQuery();
                var rowCounter = DataGridView.Rows.Count;
                var columnCounter = DataGridView.Columns.Count;

                for (int j = 1; j < columnCounter; j++)
                {
                    DataGridView.Rows[rowCounter - 1].Cells[j].Value = TxtBoxList[j - 1].Text;
                }
                id_count = int.Parse(DataGridView.Rows[rowCounter - 2].Cells[0].Value.ToString()) + 1;
                DataGridView.Rows[rowCounter - 1].Cells[0].Value = id_count.ToString();

                TxtBoxList.Clear();
            }
            else if (_mainWindow.Label2.ForeColor != Color.Green)
            {
                var row_counter = DataGridView.Rows.Count;
                var column_counter = DataGridView.Columns.Count;
                _mainWindow.changed = true;

                for (int n = 1; n < column_counter; n++)
                {
                    DataGridView.Rows[row_counter-1].Cells[n].Value = TxtBoxList[n-1].Text;
                }
                if (row_counter == 1)
                {
                    id_count = 1;
                    DataGridView.Rows[row_counter - 1].Cells[0].Value = id_count.ToString();
                }
                else if (row_counter > 1)
                {
                    id_count = Int32.Parse(DataGridView.Rows[row_counter - 2].Cells[0].Value.ToString()) + 1;
                    DataGridView.Rows[row_counter - 1].Cells[0].Value = id_count.ToString();
                }
                
                ColumnEditForm.EmptySpaceFixer();
               
            }
            Close();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            if (_mainWindow.Label2.ForeColor == Color.Green)
            {
                var counter = 1;
                for (var j = _mainWindow.ResultColumn; j < DataGridView.Columns.Count; j++)
                {
                    TxtBoxList[TxtBoxList.Count - counter].Enabled = false;
                    counter++;
                }
            }
        }

        private void CHCK_BOX_YES_CheckedChanged(object sender, EventArgs e)
        {
            CHCK_BOX_NO.Checked = !CHCK_BOX_YES.Checked;
        }

        private void CHCK_BOX_NO_CheckedChanged(object sender, EventArgs e)
        {

            CHCK_BOX_YES.Checked = !CHCK_BOX_NO.Checked;
        }
    }
}
