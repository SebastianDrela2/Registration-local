
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Registration
{
    public partial class Graph_form : Form
    {
        
        public static List<CheckBox> checkboxes = new List<CheckBox>();
        public static List<Label> labels = new List<Label>();
        public static  List<string> values = new List<string>();
        public static List<List<int>> results = new List<List<int>>();
        public static ListBox x_items = new ListBox();
        public static string result_of_selection { get; set;}
        
        
        public Graph_form()
        {
            InitializeComponent();
        }

        public void CleanUp()
        {
            checkboxes.Clear();
            values.Clear();
            labels.Clear();
            results.Clear();
            x_items.Items.Clear();
        }

        public void DisplayData()
        {
            int i = 0;
            int j = 0;
           result_of_selection = x_items.SelectedItem.ToString();
            foreach (var data in results)
            {
                j  = 0;
                chart1.Series.Add(values[i].ToString());
                foreach (var item in data)
                {
                    
                    Console.WriteLine("Ta Tabelka: " + checkboxes[i].Text.ToString());
                    Console.Write(item + "i value: " + i);
                    chart1.Series[values[i].ToString()].Points.AddXY(User_input.Dvg.Rows[j].Cells[result_of_selection + "_"].Value, item );
                    Console.WriteLine();
                    j++;

                }
                i++;
               
            }
           
         
          
        }
       

        public void GettingData()
        {
            
            

            for (int i = 0; i < values.Count; i++)
            {
                
                
                int column_index = Int32.Parse(User_input.Dvg.Columns[values[i]+ "_"].Index.ToString());
                results.Add(new List<int>());

                for (int j = 0 ; j < User_input.Dvg.Rows.Count ; j++)
                {
                    int value = Int32.Parse(User_input.Dvg.Rows[j].Cells[column_index].Value.ToString());
                    results[i].Add(value);
                }
            }
        }
        public void SelectedCheckBoxes()
        {
            
            for (int i = 0  ; i <User_input.Dvg.Columns.Count ; i++)
            {
                string check = User_input.Dvg.Rows[0].Cells[i].Value.ToString();
                if (checkboxes[i].Checked == true && Regex.IsMatch(check, @"^\d+$") == true)
                {

                    values.Add(checkboxes[i].Text);
                    
                }
            }
        }

       


        private void BTN_DRAW_Click(object sender , EventArgs e)
        {
           
            
                Console.WriteLine("What");
                chart1.Series.Clear();
                SelectedCheckBoxes();
                GettingData();
                DisplayData();

                values.Clear();

                results.Clear();
            

        }
        private void Form10_Load(object sender, EventArgs e)
        {
            

            int posx = 60;
            int posy = 15;

            for (int i = 0 ; i  < User_input.Dvg.Columns.Count ; i++)
            {
                string column_name = User_input.Dvg.Columns[i].HeaderText; 
                checkboxes.Add(new CheckBox());
                

                var check_box = checkboxes[i];
               

               
                check_box.Location = new Point(posx + 20, posy - 3);

                
                
                check_box.Text = column_name;
                check_box.Width = 200;

               
                this.Controls.Add(check_box);

                posy += 30;
            }
            
            x_items.Location = new Point(posx + 20, posy);
            for (int j = 0 ; j < User_input.Dvg.Columns.Count ; j++)
            {
                x_items.Items.Add(User_input.Dvg.Columns[j].HeaderText.ToString());
            }
           
            this.Controls.Add(x_items);
            x_items.SelectedIndex = 0;

            Button BTN_DRAW = new Button();
            BTN_DRAW.Location = new Point(100 , posy + 100);
            BTN_DRAW.Text = "Draw";
            BTN_DRAW.Height = 30;
            BTN_DRAW.Click += new EventHandler(BTN_DRAW_Click);
            
            this.Controls.Add(BTN_DRAW);
        }

        

        private void Form10_FormClosing(object sender, FormClosingEventArgs e)
        {
            CleanUp();
            e.Cancel = true;
            Console.WriteLine("heh");
            this.Hide();
        }

       
    }
}
