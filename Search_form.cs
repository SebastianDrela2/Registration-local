namespace Registration
{
    public partial class SearchForm : Form
    {
        public static Dictionary<int , string> dictionary_for_form = new Dictionary<int , string>();
        private DataGridView _dataGridView;
        public SearchForm(DataGridView dataGirdView)
        {
            _dataGridView = dataGirdView;

            InitializeComponent();
        }

        public int Index_finder_column(string text)
        {
            var result = 0;
            for (var i = 0 ; i < _dataGridView.Columns.Count ; i++)
            {
                if (_dataGridView.Columns[i].HeaderText == text)
                {
                    result = i;
                    break;
                }
               
            }
            return result;
        }
        private void BTN_OK_Click(object sender, EventArgs e)
        {
            var dictionary = new Dictionary<int , string>();
            var searchTerm = TXT_BOX_SEARCH.Text;
            var searchTermLength = searchTerm.Length;
            var i = 0;

            var index = Index_finder_column(TXT_BOX_COLUMN_NAME.Text);
           
             while (i < _dataGridView.Rows.Count)
             {
                
                var specimen = _dataGridView.Rows[i].Cells[index].Value.ToString();

                if (searchTermLength <= specimen.Length)
                {
                    var lineMaster = i;
                    var result = true;
                    for (int j = 0; j < searchTermLength; j++)
                    {
                        if (specimen[j] != searchTerm[j])

                        {
                            result = false;
                             
                        }
                    }
                    if (result)
                    {
                        
                        dictionary.Add(i, specimen);
                    }
                }
                i++;
            }

            dictionary_for_form = dictionary;
            var form6 = new Search_result_form();
            
            form6.Show();
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
