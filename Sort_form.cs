using System.ComponentModel;

namespace Registration
{
    public partial class SortForm : Form
    {
        private DataGridView _dataGridView;
        public SortForm(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
            InitializeComponent();
        }
        private void LoadColumnsIntoListBox()
        {
            for (var i = 0 ; i < _dataGridView.Columns.Count ; i++)
            {
                var columns = _dataGridView.Columns[i].HeaderText;
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
                _dataGridView.Sort(_dataGridView.Columns[result], ListSortDirection.Ascending);
            }

            else if (CHCK_BOX_DESC.Checked)
            {
                _dataGridView.Sort(_dataGridView.Columns[result], ListSortDirection.Descending);
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
