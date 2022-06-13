using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpreadSheetApp
{
    public partial class Form5 : Form
    {

        public string stringTo { get; set; }
        public int col1 { get; set; }
        public int col2 { get; set; }
        public int row1 { get; set; }
        public int row2 { get; set; }


        public Form5()
        {
            InitializeComponent();
        }

        private void inCol_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int row1toSearch) && int.TryParse(textBox1.Text, out int row2toSearch)
                && int.TryParse(Coltext.Text, out int col1toSearch) && int.TryParse(textBox3.Text, out int col2toSearch))
            {
                string str = toSearch.Text;
                this.row1 = row1toSearch;
                this.row2 = row2toSearch;
                this.col1 = col1toSearch;
                this.col2 = col2toSearch;
                
                this.stringTo = str;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }
    }
}
