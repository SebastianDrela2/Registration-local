using System.Text.RegularExpressions;

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

        private DataGridView _dataGridView;
        public Graph_form(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
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
                chart1.Series.Add(values[i]);
                foreach (var item in data)
                {
                    chart1.Series[values[i]].Points.AddXY(_dataGridView.Rows[j].Cells[result_of_selection + "_"].Value, item );
                    j++;

                }
                i++;
            }
        }
        
        public void GetData()
        {
            for (var i = 0; i < values.Count; i++)
            {
                var columnIndex = int.Parse(_dataGridView.Columns[values[i]+ "_"].Index.ToString());
                results.Add(new List<int>());

                for (int j = 0 ; j < _dataGridView.Rows.Count ; j++)
                {
                    var value = int.Parse(_dataGridView.Rows[j].Cells[columnIndex].Value.ToString());
                    results[i].Add(value);
                }
            }
        }
        public void SelectedCheckBoxes()
        {
            
            for (int i = 0  ; i < _dataGridView.Columns.Count ; i++)
            {
                var check = _dataGridView.Rows[0].Cells[i].Value.ToString();
                if (checkboxes[i].Checked && Regex.IsMatch(check, @"^\d+$"))
                {
                    values.Add(checkboxes[i].Text);
                }
            }
        }

        private void BTN_DRAW_Click(object sender , EventArgs e)
        {
            chart1.Series.Clear();
            SelectedCheckBoxes();
            GetData();
            DisplayData();

            values.Clear();

            results.Clear();
        }
        private void Form10_Load(object sender, EventArgs e)
        {
            var posx = 60;
            var posy = 15;

            for (int i = 0 ; i  < _dataGridView.Columns.Count ; i++)
            {
                var column_name = _dataGridView.Columns[i].HeaderText; 
                checkboxes.Add(new CheckBox());
                
                var check_box = checkboxes[i];
                
                check_box.Location = new Point(posx + 20, posy - 3);
                check_box.Text = column_name;
                check_box.Width = 200;

                Controls.Add(check_box);

                posy += 30;
            }
            
            x_items.Location = new Point(posx + 20, posy);
            for (int j = 0 ; j < _dataGridView.Columns.Count ; j++)
            {
                x_items.Items.Add(_dataGridView.Columns[j].HeaderText);
            }
           
            Controls.Add(x_items);
            x_items.SelectedIndex = 0;

            var btnDraw = new Button();
            btnDraw.Location = new Point(100 , posy + 100);
            btnDraw.Text = "Draw";
            btnDraw.Height = 30;
            btnDraw.Click += BTN_DRAW_Click;
            
            Controls.Add(btnDraw);
        }

        private void Form10_FormClosing(object sender, FormClosingEventArgs e)
        {
            CleanUp();
            e.Cancel = true;
            Hide();
        }
    }
}
