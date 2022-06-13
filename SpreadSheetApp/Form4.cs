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
    public partial class Form4 : Form
    {
        public string stringTo { get; set; }
        public int col { get; set; }
        public Form4()
        {
            InitializeComponent();
        }

        private void inCol_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Coltext.Text, out int rowtoSearch))
            {
                string str = toSearch.Text;
                this.col = rowtoSearch;
                this.stringTo = str;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }
    }
}
