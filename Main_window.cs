using System.Data;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Registration
{
    public partial class MainWindow : Form
    {
        public Label OnlineLabelStatus { get; set; }
        public Button SqlInfoForForm { get; set; }
        public bool RuntimeChecker { get; set; }
        public int ResultColumn  {get; set;}
        public bool FirstPass;
        public string Path  = "";
        public string FontData { get; set;}

        public int SelectedRowIndex;
        public int SelectedColumnIndex;
        public string RowName;
        public string ColumnName;
        public string CurrentCellValue;
        public string IdName;

        private Rectangle _buttonOriginalRectangle;
        private Rectangle _dataGridOriginalRectangle;     
        private Rectangle _githubTextOriginalRectangle;
        private Rectangle _linkGitHubTextOriginalRectangle;    
        private Rectangle _originalFormSize;
        private Rectangle _titleImageRectangle;
        private Rectangle _sqlInfoRectangle;
        private Rectangle _connectionStringRectangle;
        private Rectangle _connectionStatusRectangle;

        private ConnectionForm _connectionForm;
        private UserInput _userInput;

        public bool CellEdited;
        
        public MainWindow()
        {
            InitializeComponent();
        }
        
        public void SetConnectionToOffline()
        {
            RuntimeChecker = false;
            _labelConnectionStatus.Text = "O F F L I N E";
            _labelConnectionStatus.ForeColor = Color.Red;
            ConnectionForm.SqlChecker = false;
            if (RuntimeChecker)
            {
                ConnectionForm.CurrentConnection.Close();
            }

            RuntimeChecker = false;
        }
        private void ReadSettings(string fontPath)
        {
            if (File.Exists(fontPath))
            {
                var allLines = File.ReadAllLines(fontPath);
                DataGrid.Font = new Font(allLines[0], float.Parse(allLines[1]));

                var foreGroundComponents = allLines[2].Split(',');
                var fcColor = GetColorFromComponents(foreGroundComponents);
                DataGrid.ForeColor = fcColor;

                var backGroundComponents = allLines[3].Split(',');
                var fbColor = GetColorFromComponents(backGroundComponents);
                DataGrid.BackgroundColor = fbColor;
            }
            else
            {
                File.Create(fontPath);
            }
        }

        private static Color GetColorFromComponents(IReadOnlyList<string> components)
        {
            return Color.FromArgb(Convert.ToInt32(components[0]),
                Convert.ToInt32(components[1]),
                Convert.ToInt32(components[2]),
                Convert.ToInt32(components[3]));
        }
         
        public void CreateDirIfItDoesNotExist(string dirPath)
        {
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Path = "";
            var columnDirectoryPath = Application.StartupPath + "\\Columns";
            var dataDirectoryPath = Application.StartupPath + "\\Data";
            FontData = Application.StartupPath + "\\font.txt";
            
            ReadSettings(FontData);
           
            CreateDirIfItDoesNotExist(columnDirectoryPath);
            CreateDirIfItDoesNotExist(dataDirectoryPath);

            _labelConnectionStatus.Text = @"O F F L I N E";
            _labelConnectionStatus.ForeColor = Color.Red;
            ConnectionForm.SqlChecker = false;
            OnlineLabelStatus = _labelConnectionStatus;
            
            SqlInfoForForm = _buttonSqlInfo;

            if (_labelConnectionStatus.ForeColor == Color.Red)
            {
                _buttonSqlInfo.Enabled = false;
            }
            if (File.Exists(Application.StartupPath + "/Columns/entire_data_columns_data.txt")) 
            {
                DataGrid.Columns.Clear();
                
                string[] limes = File.ReadAllLines(Application.StartupPath + "/Columns/entire_data_columns_data.txt");
                foreach (var lime in limes)
                {
                    DataGrid.Columns.Add(lime + "_" , lime);
                }
                
            }

            PopulateDataGridFromEntireData();
            SetRectanglesProperties();
        }

        private void SetRectanglesProperties()
        {
            _originalFormSize = new Rectangle(Location.X, Location.Y, Size.Width, Size.Height);
            _buttonOriginalRectangle = new Rectangle(_buttonAdd.Location.X, _buttonAdd.Location.Y, _buttonAdd.Width, _buttonAdd.Height);

            _dataGridOriginalRectangle = new Rectangle(DataGrid.Location.X, DataGrid.Location.Y, DataGrid.Width, DataGrid.Height);
            _titleImageRectangle = new Rectangle(IMG_BOX_TITLE.Location.X, IMG_BOX_TITLE.Location.Y, IMG_BOX_TITLE.Width, IMG_BOX_TITLE.Height);
            _githubTextOriginalRectangle = new Rectangle(_labelGithubPrefix.Location.X, _labelGithubPrefix.Location.Y, _labelGithubPrefix.Width, _labelGithubPrefix.Height);
            _linkGitHubTextOriginalRectangle = new Rectangle(_labelGithubLink.Location.X, _labelGithubLink.Location.Y, _labelGithubLink.Width, _labelGithubLink.Height);

            _sqlInfoRectangle = new Rectangle(_buttonSqlInfo.Location.X, _buttonSqlInfo.Location.Y, _buttonSqlInfo.Width, _buttonSqlInfo.Height);
            _connectionStringRectangle = new Rectangle(LBL_CONNECTION.Location.X, LBL_CONNECTION.Location.Y, LBL_CONNECTION.Width, LBL_CONNECTION.Height);
            _connectionStatusRectangle = new Rectangle(_labelConnectionStatus.Location.X, _labelConnectionStatus.Location.Y, _labelConnectionStatus.Width, _labelConnectionStatus.Height);
        }

        private void PopulateDataGridFromEntireData()
        {
            if (File.Exists(Application.StartupPath + "/Data/entire_data.txt"))
            {
                string[] allLines = File.ReadAllLines(Application.StartupPath + "/Data/entire_data.txt");
                var counterRow = 0;
                foreach (var line in allLines)
                {
                    if (line != "//")
                    {
                        counterRow++;
                    }
                    else if (line == "//")
                    {
                        break;
                    }
                }

                for (var i = 0; i < counterRow; i++)
                {
                    DataGrid.Rows.Add();
                }

                var column = 0;
                var row = 0;

                foreach (var line in allLines)
                {
                    if (line != "//")
                    {
                        DataGrid.Rows[row].Cells[column].Value = line;

                        row++;
                    }

                    if (line == "//")
                    {
                        column++;
                        row = 0;
                    }
                }
            }
        }

        private void ResizeControl(Rectangle r, Control c)
        {
            var xRatio = Width / (float)(_originalFormSize.Width);
            var yRatio = Height / (float)(_originalFormSize.Height);

            var newX = (int)(r.Location.X * xRatio);
            var newY = (int)(r.Location.Y * yRatio);

            var newWidth = (int)(r.Width * xRatio);
            var newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void ResizeControlChildren()
        {
            ResizeControl(_buttonOriginalRectangle, _buttonAdd);
            ResizeControl(_dataGridOriginalRectangle, DataGrid);
            ResizeControl(_titleImageRectangle, IMG_BOX_TITLE);
            ResizeControl(_githubTextOriginalRectangle, _labelGithubPrefix);
            ResizeControl(_linkGitHubTextOriginalRectangle, _labelGithubLink);
            ResizeControl (_sqlInfoRectangle, _buttonSqlInfo);
            ResizeControl(_connectionStatusRectangle, _labelConnectionStatus);
            ResizeControl(_connectionStringRectangle, LBL_CONNECTION);
        }

        private void DeleteRow()
        {
            if (_labelConnectionStatus.ForeColor != Color.Red)
            {
                ConnectionForm.CurrentConnection.Open();
                var command = new SqlCommand()
                {
                    Connection = ConnectionForm.CurrentConnection,
                    CommandType = CommandType.Text,
                    CommandText = "DELETE FROM " + ConnectionForm.DataTable + " WHERE ID = " + DataGrid.CurrentCell.Value + ""
                };

                command.ExecuteNonQuery();
                ConnectionForm.CurrentConnection.Close();
                DataGrid.Rows.RemoveAt(DataGrid.SelectedRows[0].Index);
            }
            else
            {
                if (DataGrid.Rows.Count == 0)
                {
                    _userInput.IdCount = 0;
                }
                else if (DataGrid.Rows.Count == 1)
                {
                    DataGrid.Rows.Clear();
                    _userInput.IdCount = 0;
                }
                else
                {
                    var counter = 0;
                    var selectedRow = DataGrid.CurrentCell.RowIndex;
                    selectedRow++;

                    var rowCount = DataGrid.Rows.Count;
                    var operationValue = rowCount - selectedRow;

                    while (counter < operationValue)
                    {
                        DataGrid.Rows[selectedRow].Cells[0].Value = int.Parse(DataGrid.Rows[selectedRow].Cells[0].Value.ToString()) - 1;

                        selectedRow++;
                        counter++;
                    }

                    DataGrid.Rows.RemoveAt(this.DataGrid.SelectedRows[0].Index);
                    var lastindex = DataGrid.Rows.Count - 1;

                    _userInput.IdCount = int.Parse(DataGrid.Rows[lastindex].Cells[0].Value.ToString());
                }
            }
        }
      
        private void OnAddClicked(object sender, EventArgs e)
        {
            _userInput = new UserInput(this, _connectionForm);
            _userInput.Show();
            
            DataGrid.AllowUserToAddRows = false;
        }

        private void OnGithubLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/SebastianDrela2") { UseShellExecute = true });
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeControlChildren();
        }
        
        private void Save()
        {
            UserInput.EntireData.Clear();
            var counter = DataGrid.Columns.Count;

            for (var i = 0; i < counter; i++)
            {
                for (var j = 0; j < DataGrid.Rows.Count; j++)
                {
                    UserInput.EntireData.Add(DataGrid.Rows[j].Cells[i].Value.ToString());
                }
                
                UserInput.EntireData.Add("//");
            }

            var columns = new List<string>();

            for (var k = 0; k < DataGrid.Columns.Count; k++)
            {
                columns.Add(DataGrid.Columns[k].HeaderText);
            }
            CellEdited = false;

            WriteAllData(columns);
        }

        private void WriteAllData(List<string> columnsList)
        {
            if (File.Exists(Path))
            {
                Console.WriteLine(Path);
                File.Create(Path).Close();
                File.WriteAllLines(Path, UserInput.EntireData);
                File.WriteAllLines(Application.StartupPath + "/Columns/" + DatabaseEntry.path_no_txt + "_columns_data.txt", columnsList);
            }

            File.Create(Application.StartupPath + "/Data/entire_data.txt").Close();
            File.WriteAllLines(Application.StartupPath + "/Data/entire_data.txt", UserInput.EntireData);
            File.Create(Application.StartupPath + "/Columns/entire_data_columns_data.txt").Close();
            File.WriteAllLines(Application.StartupPath + "/Columns/entire_data_columns_data.txt", columnsList);
        }
            
        private void OnSaveClicked(object sender, EventArgs e)
        {
            SetConnectionToOffline();
            Save();

        }
        
        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (CellEdited)
            {
                var dialogResult = MessageBox.Show(@"Unsaved Changes close?", @"Exit", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dialogResult != DialogResult.No)
                {
                    e.Cancel = false;
                }

                if (dialogResult != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }

            var columns = new List<string>();
            for (var i = 0; i < DataGrid.Columns.Count; i++)
            {
                columns.Add(DataGrid.Columns[i].HeaderText);
            }
        }
        

        private void OnExitClicked(object sender, EventArgs e)
        {
            if (CellEdited)
            {
                var dialogResult = MessageBox.Show("Unsaved Changes close?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult != DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (CellEdited == false)
            {
                Application.Exit();
            }
        }
        
        private void OnDataGridCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGrid.SelectedCells.Count >= 1 )
            {
                SetDataGridRunTimeData();
                if (FirstPass == false)
                {
                    FirstPass = true;
                }

                if (_labelConnectionStatus.ForeColor == Color.Green && IdName != null && CurrentCellValue != null)
                {
                    var connection = new SqlConnection(_connectionForm.ConnectionString);
                    connection.Open();
                    
                    var command = new SqlCommand
                    {
                        Connection = connection,
                        CommandType = CommandType.Text,
                        CommandText = "UPDATE UserData SET " + ColumnName + " = '" + CurrentCellValue + "' WHERE ID = " + IdName

                    };
                    command.ExecuteNonQuery();
                }
            }
        }

        private void SetDataGridRunTimeData()
        {
            SelectedRowIndex = DataGrid.SelectedCells[0].RowIndex;
            SelectedColumnIndex = DataGrid.SelectedCells[0].ColumnIndex;
            RowName = DataGrid.Rows[SelectedRowIndex].ToString();
            ColumnName = DataGrid.Columns[SelectedColumnIndex].HeaderText;
            var selectedRow = DataGrid.Rows[SelectedRowIndex];
            CurrentCellValue = selectedRow.Cells[SelectedColumnIndex].Value.ToString();
            IdName = DataGrid.Rows[SelectedRowIndex].Cells[0].Value.ToString();
        }

        private void OnCellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            CellEdited = true;
        }

        private void OnOpenClicked(object sender, EventArgs e)
        {
            if (OnlineLabelStatus.ForeColor != Color.Green)
            {
                Save();
            }

            var openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SetConnectionToOffline();
                
                var filePath = openFileDialog.FileName;
                var fileExt = System.IO.Path.GetExtension(filePath);

                var filePathNoExtenstion = System.IO.Path.GetFileNameWithoutExtension(filePath);
                Path = filePath;

                var limes =
                    File.ReadAllLines(Application.StartupPath + "/Columns/" + filePathNoExtenstion + "_columns_data.txt");

                DataGrid.Columns.Clear();
                foreach (var line in limes)
                {
                    DataGrid.Columns.Add(line + "_", line);
                }

                SetDataFromOpenedData(filePath, fileExt);
            }
        }

        private void SetDataFromOpenedData(string filePath, string fileExt)
        {
            var setOfLists = new List<List<string>>();

            if (string.Compare(fileExt, ".txt", StringComparison.Ordinal) == 0)
            {
                var listIndex = 0;
                var result = File.ReadAllLines(filePath);

                var firstRoll = false;
                var counter = 0;
                var finalCounter = 0;
                setOfLists.Add(new List<string>());
                foreach (var lines in result)
                {
                    if (lines == "//")
                    {
                        listIndex++;
                        setOfLists.Add(new List<string>());
                        if (firstRoll == false)
                        {
                            finalCounter = counter;
                            firstRoll = true;
                        }
                    }
                    else if (lines != "//")
                    {
                        setOfLists[listIndex].Add(lines);
                        counter++;
                    }
                }

                DataGrid.Rows.Clear();

                var columnIndex = 0;
                for (var j = 0; j < finalCounter; j++)
                {
                    DataGrid.Rows.Add();
                }

                foreach (var list in setOfLists)
                {
                    for (var row_index = 0; row_index < list.Count; row_index++)
                    {
                        DataGrid.Rows[row_index].Cells[columnIndex].Value = list[row_index];
                    }

                    columnIndex++;
                }

                _userInput.IdCount = finalCounter;
                SetConnectionToOffline();
            }
        }

        private void OnNewClicked(object sender, EventArgs e)
        {
            SetConnectionToOffline();
            var databaseEntry = new DatabaseEntry(this);
            databaseEntry.Show();
        }

        private void OnSaveAsClicked(object sender, EventArgs e)
        {
            SetConnectionToOffline();
            var saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filepath = saveFileDialog.FileName + ".txt";
                    var stream = File.Open(filepath, FileMode.Create);
                    var writer = new StreamWriter(stream);

                    var lastRun = false;
                    for (var i = 0; i < DataGrid.Columns.Count; i++)
                    {
                        for (var j = 0; j < DataGrid.Rows.Count; j++)
                        {
                            var data = (DataGrid.Rows[j].Cells[i].Value.ToString());
                            writer.WriteLine(data);

                            if (i == DataGrid.Columns.Count - 1)
                            {
                                lastRun = true;
                            }

                        }

                        if (lastRun == false)
                        {
                            writer.WriteLine("//");
                        }
                       
                    }

                    writer.Close();
                }
                catch
                {
                    // ignored
                }
            }
        }
        
        private void OnSearchMenuItemClicked(object sender, EventArgs e)
        {
            var form4 = new SearchForm(DataGrid);
            form4.Show();
        }

        private void OnAddConnectionClicked(object sender, EventArgs e)
        {
            _connectionForm = new ConnectionForm(this);
            _connectionForm.Show();
        }

        private void OnSqlInfoClicked(object sender, EventArgs e)
        {
            MessageBox.Show(@"Ammount of Columns in SQl server : " + ResultColumn);
        }

        private void OnColumnsClicked(object sender, EventArgs e)
        {
           var frm = new ColumnEditForm(DataGrid);
           frm.Show();
        }

        private void OnHelpClicked(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Rows Can be deleted by pressing DELETE on keyboard and selecting given row File can be saved by pressing Ctrl + S");
        }

        private void OnGraphToolClicked(object sender, EventArgs e)
        {
            var frm = new GraphForm(DataGrid);
            frm.Show();
        }

        private void OnDataStyleClicked(object sender, EventArgs e)
        {
            var frm = new StyleEditForm(this);
            frm.Show();

        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Delete)
            {
                DeleteRow();
            }
            else if (e is { Control: true, KeyCode: Keys.S })
            { 
                Save();
                SetConnectionToOffline();
            }
        }

        private void OnSortClicked(object sender, EventArgs e)
        {
            var frm = new SortForm(DataGrid);
            frm.Show();
        }
    }
    }
