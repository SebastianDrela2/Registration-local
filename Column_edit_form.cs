namespace Registration
{
    public partial class ColumnEditForm : Form
    {
        private static DataGridView _dataGridView;
        public ColumnEditForm(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
            
            InitializeComponent();
        }

        public static void FixEmptySpaces()
        {
            for (var v = 0; v < _dataGridView.Columns.Count; v++)
            {
                for (var p = 0; p < _dataGridView.Rows.Count; p++)
                {
                    if (string.IsNullOrEmpty(_dataGridView.Rows[p].Cells[v].Value as string))
                    {
                        _dataGridView.Rows[p].Cells[v].Value = "N/A";
                    }

                }
            }
        }

        private void OnOkClicked(object sender, EventArgs e)
        {
            _dataGridView.ClearSelection();
            if (TXT_BOX_COLUMN.Enabled)
            {
                _dataGridView.Columns.Add(TXT_BOX_COLUMN.Text + "_" , TXT_BOX_COLUMN.Text);
            }

            if (TXT_BOX_DELETE.Enabled)
            {
                _dataGridView.Columns.Remove(TXT_BOX_DELETE.Text + "_");
            }

            if (TXT_BOX_RENAME.Enabled)
            {
                _dataGridView.Columns[""+TXT_BOX_RENAME.Text+"_"].HeaderText = TXT_BOX_FINISH_RENAME.Text;
                _dataGridView.Columns["" + TXT_BOX_RENAME.Text + "_"].Name = TXT_BOX_FINISH_RENAME.Text + "_";

            }

            FixEmptySpaces();
            _dataGridView.ClearSelection();
        }

        private void CHCK_BOX_ADD_CheckedChanged(object sender, EventArgs e)
        {
            if (CHCK_BOX_ADD.Checked)
            {
                TXT_BOX_COLUMN.Enabled = true;
            }
            else
            {
                TXT_BOX_COLUMN.Enabled = false;
            }
        }

        private void CHCK_BOX_DELETE_CheckedChanged(object sender, EventArgs e)
        {
            if (CHCK_BOX_DELETE.Checked)
            {
                TXT_BOX_DELETE.Enabled = true;
            }
            else
            {
                TXT_BOX_DELETE.Enabled = false;
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            if (CHCK_BOX_DELETE.Checked)
            {
                TXT_BOX_DELETE.Enabled = true;
            }
            else
                TXT_BOX_DELETE.Enabled = false;

            if (CHCK_BOX_ADD.Checked)
            {
                TXT_BOX_COLUMN.Enabled = true;
            }
            else
            {
                TXT_BOX_COLUMN.Enabled = false;
            }

            if (CHCK_BOX_RENAME.Checked)
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
