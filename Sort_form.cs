using System.ComponentModel;

namespace Registration
{
    public partial class SortForm : Form
    {
        public SortForm()
        {
            InitializeComponent();
        }
        private void LoadColumnsIntoListBox()
        {
            for (int i = 0 ; i < UserInput.DataGridView.Columns.Count ; i++)
            {
                var columns = UserInput.DataGridView.Columns[i].HeaderText.ToString();
                LIST_BOX_COLUMNS.Items.Add(columns);
            }
        }
        private void Form12_Load(object sender, EventArgs e)
        {
            LoadColumnsIntoListBox();
        }
       
        private void BTN_OK_Click(object sender, EventArgs e)
        {
            var result = LIST_BOX_COLUMNS.SelectedIndex;
            if (CHCK_BOX_ASCV.Checked)
            {
                UserInput.DataGridView.Sort(UserInput.DataGridView.Columns[result], ListSortDirection.Ascending);
            }

            else if (CHCK_BOX_DESC.Checked)
            {
                UserInput.DataGridView.Sort(UserInput.DataGridView.Columns[result], ListSortDirection.Descending);
            }
        }

        private void CHCK_BOX_ASCV_CheckedChanged(object sender, EventArgs e)
        {
            if (CHCK_BOX_ASCV.Checked)
            {
                CHCK_BOX_DESC.Checked = false;
            }
        }

        private void CHCK_BOX_DESC_CheckedChanged(object sender, EventArgs e)
        {
            if (CHCK_BOX_DESC.Checked)
            {
                CHCK_BOX_ASCV.Checked = false;
            }
        }
    }
}
