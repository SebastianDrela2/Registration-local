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
    public partial class Database_entry : Form
    {
        public static DataGridView datagridview1 { get; set; }
        public static string path_no_txt { get; set;}


        
        public Database_entry()
        {
            InitializeComponent();
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            
            Console.WriteLine(datagridview1.Rows.Count.ToString());

            path_no_txt = TXT_BOX_DATA_BASE_NAME.Text;
            string data_base_path = Application.StartupPath + "/Data/" + path_no_txt + ".txt";
            File.Create(data_base_path).Close();
            datagridview1.Rows.Clear();

            MainWindow.Path = data_base_path;
           
           
            this.Close();
        }

       
    }
}
