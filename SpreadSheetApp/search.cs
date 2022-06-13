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
    public partial class search : Form
    {

        public string stringTo { get; set; }
        public search()
        {
            InitializeComponent();
        }

        private void inCol_Click(object sender, EventArgs e)
        {
            string str = toSearch.Text;
            this.stringTo = str;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
