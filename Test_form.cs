using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class Test_form : Form
    {
        public Test_form()
        {
            InitializeComponent();
            Console.WriteLine("dziala");

            int posx = 100;
            int posy = 15;

            List<TextBox> TxtBoxList = new List<TextBox>();
            List<Label> LabelList = new List<Label>();
            for (int i = 1; i < User_input.Dvg.Columns.Count; i++)
            {
                TxtBoxList.Add(new TextBox());
                LabelList.Add(new Label());


                Console.WriteLine(TxtBoxList.Count.ToString());

                var txtbox = TxtBoxList[i-1];
                var label = LabelList[i-1];

                    txtbox.Location = new Point(posx-40, posy);
                    this.Controls.Add(txtbox);

                   
                
                
                    label.Location = new Point(posx - 100, posy);
                    label.Text = User_input.Dvg.Columns[i].HeaderText.ToString() + ":";
                    this.Controls.Add(label);
                
                posy += 36;
            }
            User_input.Dvg.Rows.Add();
            int row_counter = User_input.Dvg.Rows.Count;
            int column_counter = User_input.Dvg.Columns.Count;
            for (int j = 1; j < column_counter; j++)
            {
                User_input.Dvg.Rows[row_counter].Cells[j].Value = TxtBoxList[j].Text;
             }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            

            
            
            
        }

        private void Form7_Load_1(object sender, EventArgs e)
        {

        }
    }
}
