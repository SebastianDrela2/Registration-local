
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
    public partial class User_input : Form
    {
        public static DataGridView Dvg { get; set; }

        public static CheckBox CHCK_BOX { get; set; }

        public static List<TextBox> TxtBoxList = new List<TextBox>();

        public static string imie { get; set; }
        public static string nazwisko { get; set; }

        public static int id_count;
        public static bool first_time { get; set;}
        public User_input()
        {
            InitializeComponent();
            TXT_BOX_NAME2.Visible = false;
            TXT_BOX_SURNAME2.Visible = false;
            CHCK_BOX_NO.Visible = false;
            CHCK_BOX_YES.Visible = false;
            
            LBL_NAME.Visible = false;
            LBL_REGISTRATION.Visible = false;
            LBL_SURNAME.Visible = false;
            int posx = 100;
            int posy = 15;
            


            List<Label> LabelList = new List<Label>();
            for (int i = 1; i < Dvg.Columns.Count; i++)
            {
                TxtBoxList.Add(new TextBox());
                LabelList.Add(new Label());


                

                var txtbox = TxtBoxList[i - 1];
                var label = LabelList[i - 1];

                txtbox.Location = new Point(posx - 40, posy);
                this.Controls.Add(txtbox);




                label.Location = new Point(posx - 100, posy);
                label.Text = Dvg.Columns[i].HeaderText.ToString() + ":";
                this.Controls.Add(label);

                posy += 36;
            }
            BTN_OK.Location = new Point(62, posy + 30);
            BTN_FORM2_CLOSE.Location = new Point(183, posy + 30);

        }
        
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Hide();
            e.Cancel = true; // this cancels the close event.
        }


        public static List<string> entire_data = new List<string>();



        private void BTN_OK_Click(object sender, EventArgs e)
        {
            Dvg.Rows.Add();
            










            if (Main_window.label2.ForeColor == Color.Green)
            {
                string result = "INSERT INTO UserData VALUES (";
                for (int s = 0; s < Main_window.result_column - 1; s++)
                {
                    result += "'" + TxtBoxList[s].Text + "'";
                    if (s != Main_window.result_column - 2)
                    {
                        result += " ,";
                    }
                }
                result += ")";

                
                

                SqlConnection connection = new SqlConnection(Connection_Form.connection_string);
                connection.Open();
                SqlCommand command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = result
                     
                };
                command.ExecuteNonQuery();
                int row_counter = Dvg.Rows.Count;
                int column_counter = Dvg.Columns.Count;


                

                for (int j = 1; j < column_counter; j++)
                {
                    Dvg.Rows[row_counter - 1].Cells[j].Value = TxtBoxList[j - 1].Text;
                }
                id_count = Int32.Parse(Dvg.Rows[row_counter - 2].Cells[0].Value.ToString()) + 1;
                Dvg.Rows[row_counter - 1].Cells[0].Value = id_count.ToString();


                TxtBoxList.Clear();




               


            }
            else if (Main_window.label2.ForeColor != Color.Green)
            {
                
                // Dvg.Rows.Add(id_count, TXT_BOX_NAME2.Text, TXT_BOX_SURNAME2.Text, registration_status);

                int row_counter = Dvg.Rows.Count;
                int column_counter = Dvg.Columns.Count;
                Main_window.changed = true;



                for (int n = 1; n < column_counter; n++)
            {
                Dvg.Rows[row_counter-1].Cells[n].Value = TxtBoxList[n-1].Text;
            }
                if (row_counter == 1)
                {
                    id_count = 1;
                    Dvg.Rows[row_counter - 1].Cells[0].Value = id_count.ToString();
                }
                else if (row_counter > 1)
                {
                    id_count = Int32.Parse(Dvg.Rows[row_counter - 2].Cells[0].Value.ToString()) + 1;
                    Dvg.Rows[row_counter - 1].Cells[0].Value = id_count.ToString();
                }
                
                
                
                Console.WriteLine("This is id count: " + id_count);

               
                

                Column_edit_form.EmptySpaceFixer();
               
                
                
            }
            this.Close();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
             
            
            if (Main_window.label2.ForeColor == Color.Green)
            {
                int counter = 1;
                for (int j = Main_window.result_column; j < Dvg.Columns.Count; j++)
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

        private void BTN_FORM2_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        
    }
}
