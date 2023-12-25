using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Registration
{
    public partial class Main_window : Form
    {
        public static SqlConnection sql_con_refrence { get; set; }
        public static Label label2 { get; set; }
        public static Button Delete_for_form { get; set; }
        public static Button Save_for_form { get; set; }
        public static DataGridView data_grid_for_forms { get; set; }
        public static Button SQL_INFO_for_form { get; set; }
        public static bool runtime_checker { get; set; }
        public static int result_column  {get; set;}
        public bool first_pass = false;
        public static string path  = "";
        public static string cell_value = "";
        public static DataTable data_table = new DataTable();
        public static DataSet ds1 = new DataSet();
        public static string font_data { get; set;}

        private Rectangle buttonOriginalRectangle;
        private Rectangle DataGridOriginalRectangle;     
        private Rectangle GithubTextOriginalRectangle;
        private Rectangle LinkGitHubTextOriginalRectangle;    
        private Rectangle originalFormSize;
        private Rectangle title_imageRectangle;
        private Rectangle sql_info_rectangle;
        private Rectangle connection_string_rectangle;
        private Rectangle connection_status_rectangle;


        public static bool changed = false;
        
        public Main_window()
        {
            InitializeComponent();

            
        }
        
        

        public  void Connection_status_Offline()
        {
            runtime_checker = false;
            LBL_CONNECTION_STATUS.Text = "O F F L I N E";
            LBL_CONNECTION_STATUS.ForeColor = Color.Red;
            Connection_Form.SQL_Checker = false;
            if (runtime_checker == true)
            {
                Connection_Form.con.Close();
            }
            runtime_checker = false;
            
           

            
        }
        public static void FileFunction(string tekst)
        {
            if (!File.Exists(tekst))
            {
                File.Create(tekst);
            }
            else
            {
                string[] readon = File.ReadAllLines(tekst);
                data_grid_for_forms.Font = new Font(readon[0] , float.Parse(readon[1]));

                string[] fore_ground_components = readon[2].Split(',');
                Color FC_Color = Color.FromArgb(Convert.ToInt32(fore_ground_components[0]),
                               Convert.ToInt32(fore_ground_components[1]),
                               Convert.ToInt32(fore_ground_components[2]),
                               Convert.ToInt32(fore_ground_components[3]));
                data_grid_for_forms.ForeColor = FC_Color;

                string[] back_ground_components = readon[3].Split(',');
                Color FB_Color = Color.FromArgb(Convert.ToInt32(back_ground_components[0]),
                               Convert.ToInt32(back_ground_components[1]),
                               Convert.ToInt32(back_ground_components[2]),
                               Convert.ToInt32(back_ground_components[3]));
                data_grid_for_forms.BackgroundColor = FB_Color;  


            }
           
        }
         
        public void DirectoryFunction(string tekst)
        {
            if (!Directory.Exists(tekst))
            {
                Directory.CreateDirectory(tekst);
            }
           

        }
        public  void Connection_status_Online()
        {
            LBL_CONNECTION_STATUS.Text = "O N L I N E";
            LBL_CONNECTION_STATUS.ForeColor = Color.Green;
            Connection_Form.SQL_Checker = true;
           
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            data_grid_for_forms = DATA_GRID;
            path = "";
            string column_directory_path = Application.StartupPath + "\\Columns";
            string data_directory_path = Application.StartupPath + "\\Data";
            font_data = Application.StartupPath + "\\font.txt";
            Console.WriteLine(column_directory_path);
            Console.WriteLine(data_directory_path);
            Console.WriteLine(font_data);

            FileFunction(font_data);
           
            DirectoryFunction(column_directory_path);
            DirectoryFunction(data_directory_path);



            LBL_CONNECTION_STATUS.Text = "O F F L I N E";
            LBL_CONNECTION_STATUS.ForeColor = Color.Red;
            Connection_Form.SQL_Checker = false;

            Main_window f1 = new Main_window();
            User_input.Dvg = DATA_GRID;
            Search_form.dvg = DATA_GRID;
            

            label2 = LBL_CONNECTION_STATUS;
            
            
            SQL_INFO_for_form = BTN_SQL_INFO;

            if (LBL_CONNECTION_STATUS.ForeColor == Color.Red)
            {
                BTN_SQL_INFO.Enabled = false;
            }
            if (File.Exists(Application.StartupPath + "/Columns/entire_data_columns_data.txt") == true) 
            {
                DATA_GRID.Columns.Clear();
                
                string[] limes = File.ReadAllLines(Application.StartupPath + "/Columns/entire_data_columns_data.txt");
                 foreach (var lime in limes)
                {
                    DATA_GRID.Columns.Add(lime + "_" , lime);
                    Console.WriteLine("added column " + lime);
                }
                 Console.WriteLine("Test 1");
                
            }
            Database_entry.datagridview1 = DATA_GRID;
            if (File.Exists(Application.StartupPath + "/Data/entire_data.txt") == true)
            {
                string[] lines_rows = File.ReadAllLines(Application.StartupPath+ "/Data/entire_data.txt");
                int counter_row = 0;
                foreach (string line in lines_rows)
                {
                    if (line != "//")
                    {
                        counter_row++;
                    }
                    else if (line == "//")
                    {
                        break;
                    }

                }

               
                for (int i = 0; i < counter_row; i++)
                {
                    DATA_GRID.Rows.Add();
                }
               

                int s = 0;
                int l = 0;

                foreach (string line in lines_rows)
                {
                   Console.WriteLine("Column : " + s);

                    if (line != "//")
                    {
                        DATA_GRID.Rows[l].Cells[s].Value = line;
                        
                        l++;
                    }

                    if (line == "//")
                    {
                        s++;
                        l = 0;
                    }    
                    

                }



            }
                originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            buttonOriginalRectangle = new Rectangle(BTN_ADD.Location.X, BTN_ADD.Location.Y, BTN_ADD.Width, BTN_ADD.Height);
            
            DataGridOriginalRectangle = new Rectangle(DATA_GRID.Location.X, DATA_GRID.Location.Y, DATA_GRID.Width, DATA_GRID.Height);
            title_imageRectangle = new Rectangle(IMG_BOX_TITLE.Location.X, IMG_BOX_TITLE.Location.Y, IMG_BOX_TITLE.Width, IMG_BOX_TITLE.Height);
            GithubTextOriginalRectangle = new Rectangle(LBL_GiTHUB.Location.X, LBL_GiTHUB.Location.Y, LBL_GiTHUB.Width, LBL_GiTHUB.Height);
            LinkGitHubTextOriginalRectangle = new Rectangle(LINK_LBL_GITHUB.Location.X, LINK_LBL_GITHUB.Location.Y, LINK_LBL_GITHUB.Width, LINK_LBL_GITHUB.Height);
           
            sql_info_rectangle = new Rectangle(BTN_SQL_INFO.Location.X, BTN_SQL_INFO.Location.Y, BTN_SQL_INFO.Width, BTN_SQL_INFO.Height);
            connection_string_rectangle = new Rectangle(LBL_CONNECTION.Location.X, LBL_CONNECTION.Location.Y, LBL_CONNECTION.Width, LBL_CONNECTION.Height);
            connection_status_rectangle = new Rectangle(LBL_CONNECTION_STATUS.Location.X, LBL_CONNECTION_STATUS.Location.Y, LBL_CONNECTION_STATUS.Width, LBL_CONNECTION_STATUS.Height);
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

        private void resizeControlChildren()
        {
            resizeControl(buttonOriginalRectangle, BTN_ADD);
            
            resizeControl(DataGridOriginalRectangle, DATA_GRID);
            resizeControl(title_imageRectangle, IMG_BOX_TITLE);
            resizeControl(GithubTextOriginalRectangle, LBL_GiTHUB);
            resizeControl(LinkGitHubTextOriginalRectangle, LINK_LBL_GITHUB);
            
            resizeControl (sql_info_rectangle, BTN_SQL_INFO);
            resizeControl(connection_status_rectangle, LBL_CONNECTION_STATUS);
            resizeControl(connection_string_rectangle, LBL_CONNECTION);
        }

        private void DELETE_Function()
        {
            if (LBL_CONNECTION_STATUS.ForeColor != Color.Red)
            {
                Connection_Form.con.Open();
                SqlCommand command = new SqlCommand()
                {
                    Connection = Connection_Form.con,
                    CommandType = CommandType.Text,
                    CommandText = "DELETE FROM " + Connection_Form.data_table + " WHERE ID = " + DATA_GRID.CurrentCell.Value + ""
                };

                command.ExecuteNonQuery();
                Connection_Form.con.Close();
                DATA_GRID.Rows.RemoveAt(this.DATA_GRID.SelectedRows[0].Index);

            }
            else
            {


                if (DATA_GRID.Rows.Count == 0)
                {
                    User_input.id_count = 0;
                }


                if (DATA_GRID.Rows.Count == 1)
                {
                    DATA_GRID.Rows.Clear();
                    User_input.id_count = 0;
                }
                else
                {

                    int counter = 0;
                    int selected_row = DATA_GRID.CurrentCell.RowIndex;
                    selected_row++;



                    int row_count = DATA_GRID.Rows.Count;

                    int operation_value = 0;


                    operation_value = row_count - selected_row;



                    while (counter < operation_value)

                    {
                        DATA_GRID.Rows[selected_row].Cells[0].Value = Int32.Parse(DATA_GRID.Rows[selected_row].Cells[0].Value.ToString()) - 1;


                        selected_row++;

                        counter++;

                    }

                    DATA_GRID.Rows.RemoveAt(this.DATA_GRID.SelectedRows[0].Index);
                    int lastindex = DATA_GRID.Rows.Count - 1;



                    User_input.id_count = Int32.Parse(DATA_GRID.Rows[lastindex].Cells[0].Value.ToString());
                }
            }
        }
            private void BTN_ADD_Click(object sender, EventArgs e)
                
        {
          

            
        }

        private void BTN_ADD_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("not up to date");
            data_grid_for_forms = DATA_GRID;
            User_input.TxtBoxList.Clear();
            User_input frm = new User_input();
            frm.Show();
            
            
            DATA_GRID.AllowUserToAddRows = false;
            
        }

        private void LINK_LBL_GITHUB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/SebastianDrela2") { UseShellExecute = true });
            
        }

       

       

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeControlChildren();
        }
        
        
        private void Save()
        {
            User_input.entire_data.Clear();
            int counter = DATA_GRID.Columns.Count;

            for (int i = 0; i < counter; i++)
            {
                for ( int j = 0; j < DATA_GRID.Rows.Count; j++)
                {
                    User_input.entire_data.Add(DATA_GRID.Rows[j].Cells[i].Value.ToString());
                }
               
                
                
                User_input.entire_data.Add("//");
            }

            List<string> columns = new List<string>();
            for (int k = 0; k < DATA_GRID.Columns.Count; k++)
            {
                columns.Add(DATA_GRID.Columns[k].HeaderText);
            }
            changed = false;
            if (File.Exists(path))
            {
                Console.WriteLine(path.ToString());
                File.Create(path).Close();
                File.WriteAllLines(path, User_input.entire_data);



                File.WriteAllLines(Application.StartupPath + "/Columns/" + Database_entry.path_no_txt + "_columns_data.txt", columns);
            }
                
            
            File.Create(Application.StartupPath + "/Data/entire_data.txt").Close();
            File.WriteAllLines(Application.StartupPath + "/Data/entire_data.txt", User_input.entire_data);
            File.Create(Application.StartupPath + "/Columns/entire_data_columns_data.txt").Close();
            File.WriteAllLines(Application.StartupPath + "/Columns/entire_data_columns_data.txt" , columns );



            
           
        }
            
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Connection_status_Offline();
            Save();

        }
       
        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            Connection_status_Offline();
            Save();
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           if (changed == true)
            {
                DialogResult dialogresult = MessageBox.Show("Unsaved Changes close?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogresult != DialogResult.No)
                {

                    e.Cancel = false;
                }

                if(dialogresult != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
            List<string> columns = new List<string>();
           for (int i = 0; i < DATA_GRID.Columns.Count; i++)
            {
                columns.Add(DATA_GRID.Columns[i].HeaderText);

            }
             
          
           
            
           
            
        }
        

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            if (changed == true)
            {
                DialogResult dialogresult = MessageBox.Show("Unsaved Changes close?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogresult != DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (changed == false)
            {
                Application.Exit();
            }
          
           
        }
        
        private void DATA_GRID_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


            
            
            if (Connection_Form.connection_string != null && DATA_GRID.SelectedCells.Count >= 1 )
            {
                selected_row_index = DATA_GRID.SelectedCells[0].RowIndex;
                selected_column_index = DATA_GRID.SelectedCells[0].ColumnIndex;
                row_name = DATA_GRID.Rows[selected_row_index].ToString();
                column_name = DATA_GRID.Columns[selected_column_index].HeaderText;
                DataGridViewRow selectedRow = DATA_GRID.Rows[selected_row_index];
                current_cell_value = selectedRow.Cells[selected_column_index].Value.ToString();
                id_name = DATA_GRID.Rows[selected_row_index].Cells[0].Value.ToString();

                if (first_pass == false)
                {
                    SqlConnection connection = new SqlConnection(Connection_Form.connection_string);
                    
                    first_pass = true;
                }

                if (LBL_CONNECTION_STATUS.ForeColor == Color.Green && id_name != null && current_cell_value != null)
                {
                    
                    Console.WriteLine("ID : " + current_cell_value);
                    Console.WriteLine("Data: " + id_name);
                    SqlConnection connection = new SqlConnection(Connection_Form.connection_string);
                    connection.Open();
                    
                    SqlCommand command = new SqlCommand
                    {
                        Connection = connection,
                        CommandType = CommandType.Text,
                        CommandText = "UPDATE UserData SET " + column_name + " = '" + current_cell_value + "' WHERE ID = " + id_name

                    };
                    command.ExecuteNonQuery();
                    

                    Console.WriteLine("UPDATE UserData SET " + column_name + " = '" + current_cell_value + "' WHERE ID = " + id_name);
                }
            }
        }

        private void DATA_GRID_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            changed = true;
            
        }


       
       
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            
            if (label2.ForeColor != Color.Green)
            {
                Save();
            }
              
            OpenFileDialog openfiledialog = new OpenFileDialog();
            
                
                

              
            string filepath = String.Empty;
            string fileext = String.Empty;

          
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                Connection_status_Offline();
                List<string> id_set = new List<string>();
                List<string> name_set = new List<string>();
                List<string> surname_set = new List<string>();
                List<string> registration_status_set = new List<string>();
                List<List<string>> set_of_lists = new List<List<string>>();

                
                filepath = openfiledialog.FileName;
                fileext = Path.GetExtension(filepath);
                string file_path_no_txt = Path.GetFileNameWithoutExtension(filepath);
                path = filepath;

                string[] limes = File.ReadAllLines(Application.StartupPath + "/Columns/" + file_path_no_txt + "_columns_data.txt");

                DATA_GRID.Columns.Clear();
                foreach (string lime_single in limes)
                {
                    DATA_GRID.Columns.Add(lime_single + "_" , lime_single);
                }

                    if (fileext.CompareTo(".txt") == 0)
                    {
                        try
                        {
                            int list_index = 0;
                        
                            string[] result = File.ReadAllLines(filepath);
                      
                            bool first_roll = false;
                            
                            int counter = 0;
                            int final_counter = 0;
                        set_of_lists.Add(new List<string>());
                        foreach (var lines in result)
                            {
                                
                               if (lines == "//")
                               {
                                list_index++;
                                set_of_lists.Add(new List<string>());
                                 if (first_roll == false)
                                {
                                    final_counter = counter;
                                    first_roll = true; 
                                }
                               }
                               else if (lines != "//")
                            {
                                set_of_lists[list_index].Add(lines);
                                counter++;
                                
                            }
                            }
                       
                        User_input.Dvg.Rows.Clear();
                        
                        int column_index = 0;
                        for (int j = 0; j < final_counter; j++)
                        {
                            DATA_GRID.Rows.Add();
                        }
                        foreach (var list in set_of_lists)
                        { 
                            for (int row_index = 0; row_index < list.Count; row_index++)
                            {
                                DATA_GRID.Rows[row_index].Cells[column_index].Value = list[row_index];
                                
                            }
                           
                            column_index++;
                        }
                        User_input.id_count = final_counter;
                        Connection_status_Offline();
                    }
                           

                        catch (Exception ex)
                        {

                        }
                    }
                
            }
            
                
            
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Connection_status_Offline();
            Database_entry f3 = new Database_entry();
            f3.Show();
        }

        private void saveasToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Connection_status_Offline();
            SaveFileDialog saveFiledialog = new SaveFileDialog();
            string filepath = String.Empty;
            string fileext = String.Empty;



            if (saveFiledialog.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    List<string> full_data = new List<string>();
                    filepath = saveFiledialog.FileName + ".txt";

                    Stream s = File.Open(filepath, FileMode.Create);
                    StreamWriter writer = new StreamWriter(s);

                    Console.WriteLine(filepath.ToString());

                    bool last_run = false;
                    for (int i = 0; i < DATA_GRID.Columns.Count; i++)
                    {
                        for (int j = 0; j < DATA_GRID.Rows.Count; j++)
                        {
                            string data = (DATA_GRID.Rows[j].Cells[i].Value.ToString());
                            writer.WriteLine(data);

                            if (i == DATA_GRID.Columns.Count - 1)
                            {
                                last_run = true;
                            }

                        }

                        if(last_run == false)
                        {
                            writer.WriteLine("//");
                        }
                       
                    }




                    writer.Close();




                }
                catch (Exception ex)
                {

                }

            }
            }
        private void DATA_GRID_ColumnHeaderMouseClick(object sender , DataGridViewCellMouseEventArgs e)
        {
            if (this.DATA_GRID.Columns[e.ColumnIndex].Name == "ID")
            {
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot Reorder ID Values");
                }
            }
        }

       

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Search_form form4 = new Search_form();

            form4.Show();
        }

        private void DATA_GRID_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (DATA_GRID.CurrentCell.Value.ToString() == "Yes")
                {
                    DATA_GRID.CurrentCell.Value = "No";
                }
                else if (DATA_GRID.CurrentCell.Value.ToString() == "No")
                {
                    DATA_GRID.CurrentCell.Value = "Yes";

                }
            }
        }

        private void sqlConnectionToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Connection_Form f5 = new Connection_Form();
            f5.Show();
        }

        private void BTN_SQL_INFO_Click(object sender, EventArgs e)
        {
            
           
            MessageBox.Show("Ammount of Columns in SQl server : " + result_column.ToString());

            
        }

        private void columnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Column_edit_form frm = new Column_edit_form();
            frm.Show();
        }

       

        private void columnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Column_edit_form frm = new Column_edit_form();
                frm.Show();
        }
        public int selected_row_index;
        public int selected_column_index;
        public string row_name;
        public string column_name;
        public string current_cell_value;
        public string id_name;
       

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Rows Can be deleted by pressing DELETE on keyboard and selecting given row" +
                           $" File can be saved by pressing Ctrl + S");
        }

       

        private void graphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graph_form frm = new Graph_form();
            frm.Show();
        }

        private void dataStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StyleEdit_Form frm = new StyleEdit_Form();
            frm.Show();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Delete)
            {
               
                DELETE_Function();
            }
            else if (e.Control && e.KeyCode == Keys.S)
              {
                Save();
                Connection_status_Offline();
             }
            
        }

        private void sortToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Sort_Form frm = new Sort_Form();
            frm.Show();
        }
    }
    }
