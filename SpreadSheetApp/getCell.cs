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
    public partial class getCell : Form
    {

        public int col { get; set; }
        public int row { get; set; }
        public getCell()
        {
            InitializeComponent();
        }

        private void inCol_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int rowtoSearch) && int.TryParse(textBox1.Text, out int coltoSearch))

            {

                this.row = rowtoSearch;
                this.col = coltoSearch;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
