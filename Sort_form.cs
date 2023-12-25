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
    public partial class Sort_Form : Form
    {
        public Sort_Form()
        {
            InitializeComponent();
        }
        private void LoadColumnsIntoListBox()
        {
            for (int i = 0 ; i < User_input.Dvg.Columns.Count ; i++)
            {
                var columns = User_input.Dvg.Columns[i].HeaderText.ToString();
                LIST_BOX_COLUMNS.Items.Add(columns);
            }
        }
        private void Form12_Load(object sender, EventArgs e)
        {
            LoadColumnsIntoListBox();
        }
       
        private void BTN_OK_Click(object sender, EventArgs e)
        {
             string checked_box_header;
            int result = LIST_BOX_COLUMNS.SelectedIndex;
            if (CHCK_BOX_ASCV.Checked == true)
            {
                checked_box_header = CHCK_BOX_ASCV.Text;
                User_input.Dvg.Sort(User_input.Dvg.Columns[result], ListSortDirection.Ascending);
                
            }

            
            else if (CHCK_BOX_DESC.Checked == true)
            {
                checked_box_header = CHCK_BOX_DESC.Text;
                User_input.Dvg.Sort(User_input.Dvg.Columns[result], ListSortDirection.Descending);
            }

            
            
            
           
        }

        private void CHCK_BOX_ASCV_CheckedChanged(object sender, EventArgs e)
        {
            if (CHCK_BOX_ASCV.Checked == true)
            {
                CHCK_BOX_DESC.Checked = false;
            }
        }

        private void CHCK_BOX_DESC_CheckedChanged(object sender, EventArgs e)
        {
            if (CHCK_BOX_DESC.Checked == true)
            {
                CHCK_BOX_ASCV.Checked = false;
            }
        }
    }
}
