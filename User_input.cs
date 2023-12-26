using System.Data;
using System.Data.SqlClient;

namespace Registration
{
    public partial class UserInput : Form
    {
        public static List<string> EntireData = new List<string>();

        private readonly MainWindow _mainWindow;
        private readonly ConnectionForm _connectionForm;

        public List<TextBox> TxtBoxList = new List<TextBox>();
        public int IdCount;

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
            for (var i = 1; i < _mainWindow.DATA_GRID.Columns.Count; i++)
            {
                TxtBoxList.Add(new TextBox());
                labelList.Add(new Label());

                var txtbox = TxtBoxList[i - 1];
                var label = labelList[i - 1];

                txtbox.Location = new Point(posx - 40, posy);
                Controls.Add(txtbox);

                label.Location = new Point(posx - 100, posy);
                label.Text = _mainWindow.DATA_GRID.Columns[i].HeaderText + @":";
                Controls.Add(label);

                posy += 36;
            }

            BTN_OK.Location = new Point(62, posy + 30);
            BTN_FORM2_CLOSE.Location = new Point(183, posy + 30);
        }

        private void OnOkClicked(object sender, EventArgs e)
        {
            _mainWindow.DATA_GRID.Rows.Add();
           
            if (_mainWindow.OnlineLabelStatus.ForeColor == Color.Green)
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
                var rowCounter = _mainWindow.DATA_GRID.Rows.Count;
                var columnCounter = _mainWindow.DATA_GRID.Columns.Count;

                for (var j = 1; j < columnCounter; j++)
                {
                    _mainWindow.DATA_GRID.Rows[rowCounter - 1].Cells[j].Value = TxtBoxList[j - 1].Text;
                }

                IdCount = int.Parse(_mainWindow.DATA_GRID.Rows[rowCounter - 2].Cells[0].Value.ToString()) + 1;
                _mainWindow.DATA_GRID.Rows[rowCounter - 1].Cells[0].Value = IdCount.ToString();

                TxtBoxList.Clear();
            }
            else if (_mainWindow.OnlineLabelStatus.ForeColor != Color.Green)
            {
                var row_counter = _mainWindow.DATA_GRID.Rows.Count;
                var column_counter = _mainWindow.DATA_GRID.Columns.Count;
                _mainWindow.CellEdited = true;

                for (var n = 1; n < column_counter; n++)
                {
                    _mainWindow.DATA_GRID.Rows[row_counter-1].Cells[n].Value = TxtBoxList[n-1].Text;
                }
                if (row_counter == 1)
                {
                    IdCount = 1;
                    _mainWindow.DATA_GRID.Rows[row_counter - 1].Cells[0].Value = IdCount.ToString();
                }
                else if (row_counter > 1)
                {
                    IdCount = int.Parse(_mainWindow.DATA_GRID.Rows[row_counter - 2].Cells[0].Value.ToString()) + 1;
                    _mainWindow.DATA_GRID.Rows[row_counter - 1].Cells[0].Value = IdCount.ToString();
                }

                for (var v = 0; v < _mainWindow.DATA_GRID.Columns.Count; v++)
                {
                    for (var p = 0; p < _mainWindow.DATA_GRID.Rows.Count; p++)
                    {
                        if (string.IsNullOrEmpty(_mainWindow.DATA_GRID.Rows[p].Cells[v].Value as string))
                        {
                            _mainWindow.DATA_GRID.Rows[p].Cells[v].Value = "N/A";
                        }

                    }
                }

            }

            Close();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            if (_mainWindow.OnlineLabelStatus.ForeColor == Color.Green)
            {
                var counter = 1;
                for (var j = _mainWindow.ResultColumn; j < _mainWindow.DATA_GRID.Columns.Count; j++)
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
