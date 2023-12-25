
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class Connection_Form : Form
    {
        public static bool SQL_Checker { get; set; }
        public static string connection_string { get; set; }

        public static SqlConnection con { get; set; }
        public static List<string> Sql_Table_names { get; set;}
        public static string data_table { get; set;}
        public static List<int> id_list = new List<int>();
        public static List<List<string>> Lista_string = new List<List<string>>();


        public static void ColumnRemover(int field_count)
        {
            int count = User_input.Dvg.Columns.Count;
            int operation_result = count - field_count;
            count = count - 1;

            for (int i = 0; i < operation_result; i++)
            {

                User_input.Dvg.Columns.RemoveAt(count - i);
            }

        }
        public static void DisplayData()
        {
            
            using SqlCommand cmd = new SqlCommand
            {
                Connection = con,
                CommandType = CommandType.Text,
                CommandText = "SELECT * FROM " + data_table
            };
            con.Open();
            using SqlDataReader sqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            ColumnRemover(sqlDataReader.FieldCount);
            while (sqlDataReader.Read())
            {
                id_list.Add(Int32.Parse(sqlDataReader[0].ToString()));

                for (int m = 0; m < Main_window.result_column - 1; m++)
                {
                    Lista_string[m].Add(sqlDataReader[m + 1].ToString());
                }



                User_input.Dvg.ClearSelection();
            }
            User_input.Dvg.Rows.Clear();
            con.Close();
            for (int i = 0; i < id_list.Count; i++)
            {
                User_input.Dvg.Rows.Add();
                User_input.Dvg.ClearSelection();
            }

            for (int j = 0; j < id_list.Count; j++)
            {
                User_input.Dvg.Rows[j].Cells[0].Value = id_list[j];

                for (int p = 0; p < Main_window.result_column - 1; p++)
                {
                    var list = Lista_string[p];
                    Console.WriteLine(list[j].ToString());
                    User_input.Dvg.Rows[j].Cells[p + 1].Value = list[j].ToString();
                }



                User_input.Dvg.ClearSelection();
            }








            User_input.Dvg.ClearSelection();
        }
        
        public Connection_Form()
        {
            InitializeComponent();
        }
        
        List<string> name_list = new List<string>();
        List<string> surname_list = new List<string>();
        List<string> reg_status_list = new List<string>();
        
        
        public void BTN_OK_Click(object sender, EventArgs e)
        {
            

            BTN_PROCEED.Enabled = true;
            connection_string = TXT_BOT_CONNECTION.Text;
            SqlConnection connection_forward_data = new SqlConnection(connection_string);
            connection_forward_data.Open();

            SqlCommand command_forward_data = new SqlCommand()
            {
                Connection = connection_forward_data,
                CommandType = CommandType.Text,
                CommandText = "SELECT name FROM sys.tables"
            };

            SqlDataReader reader = command_forward_data.ExecuteReader();
            
                int readers_value = reader.FieldCount;
                while(reader.Read())
                {
                    for (int i = 0 ; i < reader.FieldCount ; i++)
                    {
                    LIST_BOX_DT.Items.Add(reader[i]);
                    }
                }
            
            connection_forward_data.Close();

            
        }

       

        private void BTN_PROCEED_Click(object sender, EventArgs e)
        {
            string column_name;
            for (int s = 1; s < User_input.Dvg.Columns.Count; s++)
            {
                column_name = User_input.Dvg.Columns[s].Name;
                User_input.Dvg.Columns.Remove(column_name);
            }
            data_table =  LIST_BOX_DT.SelectedItem.ToString(); 
            Main_window.runtime_checker = true;
            Main_window.label2.Text = "O N L I N E";
            Main_window.label2.ForeColor = Color.Green;
           
            
            Main_window.SQL_INFO_for_form.Enabled = true;
            User_input.Dvg.ClearSelection();

            SqlConnection connection = new SqlConnection(Connection_Form.connection_string);
            connection.Open();
            SqlCommand command = new SqlCommand()
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = "SELECT count(*) FROM information_schema.columns WHERE table_name = '"+data_table+"'"
            };

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Main_window.result_column = reader.GetInt32(0);
                    User_input.Dvg.ClearSelection();
                }
            }
            connection.Close();
            User_input.Dvg.ClearSelection();


            

            for (int o = 0; o < Main_window.result_column - 1; o++)
            {
                Lista_string.Add(new List<string>());
            }

            con = new SqlConnection(connection_string);
            con.Open();

            using SqlCommand cmd2 = new SqlCommand
            {
                Connection = con,
                CommandType = CommandType.Text,
                CommandText = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + data_table + "'"
            };
            User_input.Dvg.ClearSelection();
            SqlDataReader sqldatareader2 = cmd2.ExecuteReader();
            List<string> list_results = new List<string>();
            while (sqldatareader2.Read())
            {
                list_results.Add(sqldatareader2[0].ToString());
                User_input.Dvg.ClearSelection();
            }

            User_input.Dvg.ClearSelection();
           

            User_input.Dvg.ClearSelection();

            
            
            User_input.Dvg.ClearSelection();

            ColumnRemover(Main_window.result_column);
            User_input.Dvg.ClearSelection();

          
           

            for (int k = 1; k < Main_window.result_column; k++)
            {
                User_input.Dvg.Columns.Add(list_results[k] + "_" , list_results[k]);
                User_input.Dvg.Columns[k].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            }

            con.Close();
           
            User_input.Dvg.ClearSelection();
            DisplayData();
            this.Close();
        }
    }
}
