using SpreadsheetApp;
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


    public partial class Form2 : Form
    {

        public int Returnrow { get; set; }
        public int Returncol { get; set; }
        public Form2()
        {

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void addbutton1_Click(object sender, EventArgs e)
        {
            bool s1 = int.TryParse(rowstextBox.Text, out int r);
            bool s2 = int.TryParse(colsTextBox.Text, out int c);
            if(!s1 || !s2)
            {
                MessageBox.Show("please enter numbers");
                this.Close();

            }
            this.Returnrow = r;
            this.Returncol = c;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}




//namespace SpreadsheetApp
//{
//    public partial class Form1 : Form
//    {
//        static int rows = 0, cols = 0;
//        private SharableSpreadSheet spreadsheet = new SharableSpreadSheet(rows, cols);
//        public Form1()
//        {
//            InitializeComponent();
//            tbFile.ForeColor = SystemColors.GrayText;
//            tbFile.Text = "File";
//            this.tbFile.Leave += new System.EventHandler(this.tbFile_Leave);
//            this.tbFile.Enter += new System.EventHandler(this.tbFile_Enter);
//            tbRow.ForeColor = SystemColors.GrayText;
//            tbRow.Text = "Row";
//            this.tbRow.Leave += new System.EventHandler(this.tbRow_Leave);
//            this.tbRow.Enter += new System.EventHandler(this.tbRow_Enter);
//            tbCol.ForeColor = SystemColors.GrayText;
//            tbCol.Text = "Column";
//            this.tbCol.Leave += new System.EventHandler(this.tbCol_Leave);
//            this.tbCol.Enter += new System.EventHandler(this.tbCol_Enter);
//            tbData.ForeColor = SystemColors.GrayText;
//            tbData.Text = "text";
//            this.tbData.Leave += new System.EventHandler(this.tbData_Leave);
//            this.tbData.Enter += new System.EventHandler(this.tbData_Enter);
//            tbRow1.ForeColor = SystemColors.GrayText;
//            tbRow1.Text = "Row1";
//            this.tbRow1.Leave += new System.EventHandler(this.tbRow1_Leave);
//            this.tbRow1.Enter += new System.EventHandler(this.tbRow1_Enter);
//            tbRow2.ForeColor = SystemColors.GrayText;
//            tbRow2.Text = "Row2";
//            this.tbRow2.Leave += new System.EventHandler(this.tbRow2_Leave);
//            this.tbRow2.Enter += new System.EventHandler(this.tbRow2_Enter);
//            tbCol1.ForeColor = SystemColors.GrayText;
//            tbCol1.Text = "Column1";
//            this.tbCol1.Leave += new System.EventHandler(this.tbCol1_Leave);
//            this.tbCol1.Enter += new System.EventHandler(this.tbCol1_Enter);
//            tbCol2.ForeColor = SystemColors.GrayText;
//            tbCol2.Text = "Column2";
//            this.tbCol2.Leave += new System.EventHandler(this.tbCol2_Leave);
//            this.tbCol2.Enter += new System.EventHandler(this.tbCol2_Enter);
//            tbDataR.ForeColor = SystemColors.GrayText;
//            tbDataR.Text = "text";
//            this.tbDataR.Leave += new System.EventHandler(this.tbDataR_Leave);
//            this.tbDataR.Enter += new System.EventHandler(this.tbDataR_Enter);
//            tbAddRow.ForeColor = SystemColors.GrayText;
//            tbAddRow.Text = "Row";
//            this.tbAddRow.Leave += new System.EventHandler(this.tbAddRow_Leave);
//            this.tbAddRow.Enter += new System.EventHandler(this.tbAddRow_Enter);
//            tbAddCol.ForeColor = SystemColors.GrayText;
//            tbAddCol.Text = "Column";
//            this.tbAddCol.Leave += new System.EventHandler(this.tbAddCol_Leave);
//            this.tbAddCol.Enter += new System.EventHandler(this.tbAddCol_Enter);

//        }

//        private void tbAddCol_Enter(object sender, EventArgs e)
//        {
//            if (tbAddCol.Text == "Column")
//            {
//                tbAddCol.Text = "";
//                tbAddCol.ForeColor = SystemColors.WindowText;
//            }
//        }

//        private void tbAddCol_Leave(object sender, EventArgs e)
//        {
//            if (tbAddCol.Text.Length == 0)
//            {
//                tbAddCol.Text = "Column";
//                tbAddCol.ForeColor = SystemColors.GrayText;
//            }
//        }

//        private void tbAddRow_Enter(object sender, EventArgs e)
//        {
//            if (tbAddRow.Text == "Row")
//            {
//                tbAddRow.Text = "";
//                tbAddRow.ForeColor = SystemColors.WindowText;
//            }
//        }

//        private void tbAddRow_Leave(object sender, EventArgs e)
//        {
//            if (tbAddRow.Text.Length == 0)
//            {
//                tbAddRow.Text = "Row";
//                tbAddRow.ForeColor = SystemColors.GrayText;
//            }
//        }

//        private void tbDataR_Enter(object sender, EventArgs e)
//        {
//            if (tbDataR.Text == "text")
//            {
//                tbDataR.Text = "";
//                tbDataR.ForeColor = SystemColors.WindowText;
//            }
//        }

//        private void tbDataR_Leave(object sender, EventArgs e)
//        {
//            if (tbDataR.Text.Length == 0)
//            {
//                tbDataR.Text = "text";
//                tbDataR.ForeColor = SystemColors.GrayText;
//            }
//        }
//        private void tbCol2_Enter(object sender, EventArgs e)
//        {
//            if (tbCol2.Text == "Column2")
//            {
//                tbCol2.Text = "";
//                tbCol2.ForeColor = SystemColors.WindowText;
//            }
//        }

//        private void tbCol2_Leave(object sender, EventArgs e)
//        {
//            if (tbCol2.Text.Length == 0)
//            {
//                tbCol2.Text = "Column2";
//                tbCol2.ForeColor = SystemColors.GrayText;
//            }
//        }

//        private void tbCol1_Enter(object sender, EventArgs e)
//        {
//            if (tbCol1.Text == "Column1")
//            {
//                tbCol1.Text = "";
//                tbCol1.ForeColor = SystemColors.WindowText;
//            }
//        }

//        private void tbCol1_Leave(object sender, EventArgs e)
//        {
//            if (tbCol1.Text.Length == 0)
//            {
//                tbCol1.Text = "Column1";
//                tbCol1.ForeColor = SystemColors.GrayText;
//            }
//        }
//        private void tbRow2_Enter(object sender, EventArgs e)
//        {
//            if (tbRow2.Text == "Row2")
//            {
//                tbRow2.Text = "";
//                tbRow2.ForeColor = SystemColors.WindowText;
//            }
//        }

//        private void tbRow2_Leave(object sender, EventArgs e)
//        {
//            if (tbRow2.Text.Length == 0)
//            {
//                tbRow2.Text = "Row2";
//                tbRow2.ForeColor = SystemColors.GrayText;
//            }
//        }

//        private void tbRow1_Enter(object sender, EventArgs e)
//        {
//            if (tbRow1.Text == "Row1")
//            {
//                tbRow1.Text = "";
//                tbRow1.ForeColor = SystemColors.WindowText;
//            }
//        }

//        private void tbRow1_Leave(object sender, EventArgs e)
//        {
//            if (tbRow1.Text.Length == 0)
//            {
//                tbRow1.Text = "Row1";
//                tbRow1.ForeColor = SystemColors.GrayText;
//            }
//        }

//        private void tbData_Enter(object sender, EventArgs e)
//        {
//            if (tbData.Text == "text")
//            {
//                tbData.Text = "";
//                tbData.ForeColor = SystemColors.WindowText;
//            }
//        }

//        private void tbData_Leave(object sender, EventArgs e)
//        {
//            if (tbData.Text.Length == 0)
//            {
//                tbData.Text = "text";
//                tbData.ForeColor = SystemColors.GrayText;
//            }
//        }

//        private void tbCol_Enter(object sender, EventArgs e)
//        {
//            if (tbCol.Text == "Column")
//            {
//                tbCol.Text = "";
//                tbCol.ForeColor = SystemColors.WindowText;
//            }
//        }

//        private void tbCol_Leave(object sender, EventArgs e)
//        {
//            if (tbCol.Text.Length == 0)
//            {
//                tbCol.Text = "Column";
//                tbCol.ForeColor = SystemColors.GrayText;
//            }
//        }

//        private void tbFile_Enter(object sender, EventArgs e)
//        {
//            if (tbFile.Text == "File")
//            {
//                tbFile.Text = "";
//                tbFile.ForeColor = SystemColors.WindowText;
//            }
//        }
//        private void tbFile_Leave(object sender, EventArgs e)
//        {
//            if (tbFile.Text.Length == 0)
//            {
//                tbFile.Text = "File";
//                tbFile.ForeColor = SystemColors.GrayText;
//            }
//        }
//        private void tbRow_Enter(object sender, EventArgs e)
//        {
//            if (tbRow.Text == "Row")
//            {
//                tbRow.Text = "";
//                tbRow.ForeColor = SystemColors.WindowText;
//            }
//        }
//        private void tbRow_Leave(object sender, EventArgs e)
//        {
//            if (tbRow.Text.Length == 0)
//            {
//                tbRow.Text = "Row";
//                tbRow.ForeColor = SystemColors.GrayText;
//            }
//        }
//        private void Form1_Load(object sender, EventArgs e)
//        {
//        }

//        private void btnLoad_Click(object sender, EventArgs e)
//        {

//            if (spreadsheet.load(tbFile.Text))
//            {
//                dataGridView.Rows.Clear();
//                dataGridView.Columns.Clear();
//                dataGridView.Refresh();
//                for (int i = 0; i < spreadsheet.getCols(); i++)
//                {
//                    dataGridView.Columns.Add("", "");
//                }
//                for (int i = 0; i < spreadsheet.getRows() - 1; i++)
//                {
//                    dataGridView.Rows.Add();
//                }
//                for (int i = 0; i < spreadsheet.getRows(); i++)
//                {
//                    for (int j = 0; j < spreadsheet.getCols(); j++)
//                    {
//                        dataGridView[j, i].Value = spreadsheet.getCell(i + 1, j + 1);
//                    }
//                }
//            }
//            else
//                MessageBox.Show("Error 404 file not found");

//        }

//        private void btnSave_Click(object sender, EventArgs e)
//        {
//            if (dataGridView.Rows.Count != 0)
//            {
//                if (spreadsheet.save("spreadsheet.dat"))
//                    MessageBox.Show("Saved succesfully");
//                else
//                    MessageBox.Show("unable to save");
//            }
//        }

//        private void btnGetCell_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                int Row = Convert.ToInt32(tbRow.Text);
//                int col = Convert.ToInt32(tbCol.Text);
//                string data = spreadsheet.getCell(Row, col);
//                if (data != null)
//                    MessageBox.Show(spreadsheet.getCell(Row, col));
//                else
//                    MessageBox.Show("invalid argument in Row/Column");
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("invalid argument in Row/Column");
//            }

//        }

//        private void btnSetCell_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                if (spreadsheet.setCell(Convert.ToInt32(tbRow.Text), Convert.ToInt32(tbCol.Text), tbData.Text))
//                    dataGridView[Convert.ToInt32(tbCol.Text) - 1, Convert.ToInt32(tbRow.Text) - 1].Value = tbData.Text;
//                else
//                    MessageBox.Show("invalid argument in Row/Column");
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("invalid argument in Row/Column");
//            }
//        }

//        private void btnSearch_Click(object sender, EventArgs e)
//        {
//            int row = 0, col = 0;
//            if (spreadsheet.searchString(tbData.Text, ref row, ref col))
//            {
//                MessageBox.Show("found in cell (" + row + "," + col + ")");
//                tbRow.ForeColor = SystemColors.WindowText;
//                tbRow.Text = string.Copy(Convert.ToString(row));
//                tbCol.ForeColor = SystemColors.WindowText;
//                tbCol.Text = string.Copy(Convert.ToString(col));
//            }
//            else
//                MessageBox.Show("error 404 data not found");
//        }

//        private void btnSearchInRow_Click(object sender, EventArgs e)
//        {
//            int col = 0;
//            try
//            {
//                if (spreadsheet.searchInRow(Convert.ToInt32(tbRow.Text), tbData.Text, ref col))
//                {
//                    MessageBox.Show("found in cell (" + Convert.ToInt32(tbRow.Text) + "," + col + ")");
//                    tbCol.ForeColor = SystemColors.WindowText;
//                    tbCol.Text = string.Copy(Convert.ToString(col));
//                }
//                else
//                    MessageBox.Show("error 404 data not found");
//            }
//            catch
//            {
//                MessageBox.Show("invalid argument in Row");
//            }
//        }

//        private void btnSearchInCol_Click(object sender, EventArgs e)
//        {
//            int row = 0;
//            try
//            {
//                if (spreadsheet.searchInCol(Convert.ToInt32(tbCol.Text), tbData.Text, ref row))
//                {
//                    MessageBox.Show("found in cell (" + row + "," + Convert.ToInt32(tbCol.Text) + ")");
//                    tbRow.ForeColor = SystemColors.WindowText;
//                    tbRow.Text = string.Copy(Convert.ToString(row));
//                }
//                else
//                    MessageBox.Show("error 404 data not found");
//            }
//            catch
//            {
//                MessageBox.Show("invalid argument in Column");
//            }
//        }


//        private void btnExchangeRows_Click(object sender, EventArgs e)
//        {
//            if (spreadsheet.exchangeRows(Convert.ToInt32(tbRow1.Text), Convert.ToInt32(tbRow2.Text)))
//            {
//                for (int i = 0; i < spreadsheet.getCols(); i++)
//                {
//                    dataGridView[i, Convert.ToInt32(tbRow1.Text) - 1].Value = spreadsheet.getCell(Convert.ToInt32(tbRow1.Text), i + 1);
//                    dataGridView[i, Convert.ToInt32(tbRow2.Text) - 1].Value = spreadsheet.getCell(Convert.ToInt32(tbRow2.Text), i + 1);
//                }
//            }
//            else
//                MessageBox.Show("invalid argument in Row1/Row2");
//        }

//        private void btnExchangeCols_Click(object sender, EventArgs e)
//        {
//            if (spreadsheet.exchangeCols(Convert.ToInt32(tbCol1.Text), Convert.ToInt32(tbCol2.Text)))
//            {
//                for (int i = 0; i < spreadsheet.getRows(); i++)
//                {
//                    dataGridView[Convert.ToInt32(tbCol2.Text) - 1, i].Value = spreadsheet.getCell(i + 1, Convert.ToInt32(tbCol2.Text));
//                    dataGridView[Convert.ToInt32(tbCol1.Text) - 1, i].Value = spreadsheet.getCell(i + 1, Convert.ToInt32(tbCol1.Text));
//                }
//            }
//            else
//                MessageBox.Show("invalid argument in Col1/Col2");
//        }

//        private void btnSearchInRange_Click(object sender, EventArgs e)
//        {
//            int row = 0, col = 0;
//            if (spreadsheet.searchInRange(Convert.ToInt32(tbCol1.Text), Convert.ToInt32(tbCol2.Text), Convert.ToInt32(tbRow1.Text), Convert.ToInt32(tbRow2.Text), tbDataR.Text, ref row, ref col))
//            {
//                MessageBox.Show("found in cell (" + row + "," + col + ")");
//            }
//            else
//                MessageBox.Show("error 404 data not found Or invalid argument in Col1/Col2/Row1/Row2");
//        }

//        private void btnAddRow_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                if (spreadsheet.addRow(Convert.ToInt32(tbAddRow.Text)))
//                {
//                    dataGridView.Rows.Add();
//                    for (int i = Convert.ToInt32(tbAddRow.Text); i < spreadsheet.getRows(); i++)
//                    {
//                        for (int j = 0; j < spreadsheet.getCols(); j++)
//                        {
//                            dataGridView[j, i].Value = spreadsheet.getCell(i + 1, j + 1);
//                        }
//                    }
//                }
//                else
//                    MessageBox.Show("invalid argument in Row");
//            }
//            catch
//            {
//                MessageBox.Show("invalid argument in Row");
//            }

//        }
//        private void btnAddCol_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                if (spreadsheet.addCol(Convert.ToInt32(tbAddCol.Text)))
//                {
//                    dataGridView.Columns.Add("", "");
//                    for (int i = 0; i < spreadsheet.getRows(); i++)
//                    {
//                        for (int j = Convert.ToInt32(tbAddCol.Text); j < spreadsheet.getCols(); j++)
//                        {
//                            dataGridView[j, i].Value = spreadsheet.getCell(i + 1, j + 1);
//                        }
//                    }
//                }
//                else
//                    MessageBox.Show("invalid argument in Col");
//            }
//            catch
//            {
//                MessageBox.Show("invalid argument in Col");
//            }
//        }


//        private void btnGetSize_Click(object sender, EventArgs e)
//        {
//            int row = 0, col = 0;
//            spreadsheet.getSize(ref row, ref col);
//            MessageBox.Show("(" + row + "," + col + ")");
//        }
//    }
//}

