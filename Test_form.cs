namespace Registration
{
    public partial class TestForm : Form
    {
        private DataGridView _dataGridView;
        public TestForm(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
            InitializeComponent();

            var posx = 100;
            var posy = 15;

            var txtBoxList = new List<TextBox>();
            var labelList = new List<Label>();
            for (int i = 1; i < _dataGridView.Columns.Count; i++)
            {
                txtBoxList.Add(new TextBox());
                labelList.Add(new Label());

                var txtbox = txtBoxList[i - 1];
                var label = labelList[i - 1];

                txtbox.Location = new Point(posx - 40, posy);
                Controls.Add(txtbox);

                label.Location = new Point(posx - 100, posy);
                label.Text = _dataGridView.Columns[i].HeaderText.ToString() + ":";
                Controls.Add(label);

                posy += 36;
            }
            _dataGridView.Rows.Add();
            var rowCounter = _dataGridView.Rows.Count;
            var columnCounter = _dataGridView.Columns.Count;
            for (var j = 1; j < columnCounter; j++)
            {
                _dataGridView.Rows[rowCounter].Cells[j].Value = txtBoxList[j].Text;
            }
        }
    }
}
