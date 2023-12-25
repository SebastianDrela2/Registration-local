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
    public partial class Column_edit_form : Form


    {
        public static void EmptySpaceFixer()
        {
            for (int v = 0; v < User_input.Dvg.Columns.Count; v++)
            {
                for (int p = 0; p < User_input.Dvg.Rows.Count; p++)
                {
                    if (String.IsNullOrEmpty(User_input.Dvg.Rows[p].Cells[v].Value as String))
                    {
                        User_input.Dvg.Rows[p].Cells[v].Value = "N/A";
                    }

                }
            }
        }
        public Column_edit_form()
        {
            InitializeComponent();
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            User_input.Dvg.ClearSelection();
            if (TXT_BOX_COLUMN.Enabled == true)
            {
                User_input.Dvg.Columns.Add(TXT_BOX_COLUMN.Text + "_" , TXT_BOX_COLUMN.Text);
            }

            if (TXT_BOX_DELETE.Enabled == true)
            {
                User_input.Dvg.Columns.Remove(TXT_BOX_DELETE.Text + "_");
            }

            if (TXT_BOX_RENAME.Enabled == true)
            {
                User_input.Dvg.Columns[""+TXT_BOX_RENAME.Text+"_"].HeaderText = TXT_BOX_FINISH_RENAME.Text;
                User_input.Dvg.Columns["" + TXT_BOX_RENAME.Text + "_"].Name = TXT_BOX_FINISH_RENAME.Text + "_";

            }

           EmptySpaceFixer();
            User_input.Dvg.ClearSelection();
        }

        private void CHCK_BOX_ADD_CheckedChanged(object sender, EventArgs e)
        {
            if (CHCK_BOX_ADD.Checked == true)
            {
                TXT_BOX_COLUMN.Enabled = true;
            }
            else
                TXT_BOX_COLUMN.Enabled = false;
        }

        private void CHCK_BOX_DELETE_CheckedChanged(object sender, EventArgs e)
        {
            if (CHCK_BOX_DELETE.Checked == true)
            {
                TXT_BOX_DELETE.Enabled = true;
            }
            else
                TXT_BOX_DELETE.Enabled = false;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            if (CHCK_BOX_DELETE.Checked == true)
            {
                TXT_BOX_DELETE.Enabled = true;
            }
            else
                TXT_BOX_DELETE.Enabled = false;

            if (CHCK_BOX_ADD.Checked == true)
            {
                TXT_BOX_COLUMN.Enabled = true;
            }
            else
                TXT_BOX_COLUMN.Enabled = false;

            if (CHCK_BOX_RENAME.Checked == true)
            {
                TXT_BOX_RENAME.Enabled = true;
                TXT_BOX_FINISH_RENAME.Enabled = true;
            }
            else
            {
                TXT_BOX_RENAME.Enabled = false;
                TXT_BOX_FINISH_RENAME.Enabled = false;
            }
            }

            private void CHCK_BOX_RENAME_CheckedChanged(object sender, EventArgs e)
        {
            if (CHCK_BOX_RENAME.Checked == true)
            {
                TXT_BOX_RENAME.Enabled = true;
                TXT_BOX_FINISH_RENAME.Enabled = true;
            }
            else
            {
                TXT_BOX_RENAME.Enabled = false;
                TXT_BOX_FINISH_RENAME.Enabled = false;
            }
            
        }
    }
}
