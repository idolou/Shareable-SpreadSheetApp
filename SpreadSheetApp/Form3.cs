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

    public partial class Form3 : Form
    {

        public string stringTo { get; set; }
        public int row { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void inRow_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int rowtoSearch))
            {
                string str = toSearch.Text;
                this.row = rowtoSearch;
                this.stringTo = str;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }
    }
}
