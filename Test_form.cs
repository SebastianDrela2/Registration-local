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
            for (int i = 1; i < UserInput.DataGridView.Columns.Count; i++)
            {
                TxtBoxList.Add(new TextBox());
                LabelList.Add(new Label());


                Console.WriteLine(TxtBoxList.Count.ToString());

                var txtbox = TxtBoxList[i-1];
                var label = LabelList[i-1];

                    txtbox.Location = new Point(posx-40, posy);
                    this.Controls.Add(txtbox);

                   
                
                
                    label.Location = new Point(posx - 100, posy);
                    label.Text = UserInput.DataGridView.Columns[i].HeaderText.ToString() + ":";
                    this.Controls.Add(label);
                
                posy += 36;
            }
            UserInput.DataGridView.Rows.Add();
            int row_counter = UserInput.DataGridView.Rows.Count;
            int column_counter = UserInput.DataGridView.Columns.Count;
            for (int j = 1; j < column_counter; j++)
            {
                UserInput.DataGridView.Rows[row_counter].Cells[j].Value = TxtBoxList[j].Text;
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
