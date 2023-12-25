namespace Registration
{
    public partial class Search_form : Form
    {
        public static Dictionary<int , string> dictionary_for_form = new Dictionary<int , string>();
        public static DataGridView dvg { get; set; }
        public Search_form()
        {
            InitializeComponent();
        }

        public int Index_finder_column(string tekst)
        {
           int result = 0;
            for (int i = 0 ; i < UserInput.DataGridView.Columns.Count ; i++)
            {
                if (UserInput.DataGridView.Columns[i].HeaderText == tekst)
                {
                    result = i;
                    break;
                }
               
            }
            return result;
        }
        private void BTN_OK_Click(object sender, EventArgs e)
        {
            Dictionary<int , string> dictionary = new Dictionary<int , string>();
            string search_term = TXT_BOX_SEARCH.Text;
            int search_term_length = search_term.Length;
            int i = 0;
            int column = 0;
            int counter = 0;
           
            int index = Index_finder_column(TXT_BOX_COLUMN_NAME.Text);
           
             while (i < UserInput.DataGridView.Rows.Count)
            {
                
                string specimen = UserInput.DataGridView.Rows[i].Cells[index].Value.ToString();

                

                if (search_term_length <= specimen.Length)
                {
                    int line_master = i;
                    bool result = true;
                    for (int j = 0; j < search_term_length; j++)
                    {
                        if (specimen[j] != search_term[j])

                        {
                            result = false;
                             
                        }
                       

                    }
                    if (result == true)
                    {
                        
                        dictionary.Add(i, specimen);
                    }

                    /* ver 1.0
                    if (result == true)
                    {
                        line_master++;
                        MessageBox.Show("Value Found at Row " + line_master);
                        line_master--;
                        
                        dvg.CurrentCell = dvg.Rows[line_master].Cells[column];
                        this.Close();
                        break;

                    }
                    else if (result == false)
                    {
                        MessageBox.Show("Value Cannot be found");
                    }
                   
                    */
                }
                i++;


            }


            dictionary_for_form = dictionary;
            Search_result_form form6 = new Search_result_form();
            
            form6.Show();

             

           
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void LBL_NAME_Click(object sender, EventArgs e)
        {

        }

     

        private void TXT_BOX_SEARCH_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
