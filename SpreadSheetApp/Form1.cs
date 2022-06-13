using SpreadsheetApp;

namespace SpreadSheetApp
{
    public partial class Form1 : Form
    {

        public int Rows { get; set; } = 0;
        public int Cols { get; set; } =0;
    SharableSpreadSheet spreadsheet;// = new SharableSpreadSheet(0,0);

        public Form1()
        {
            spreadsheet = new SharableSpreadSheet(Rows, Cols);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            spreadsheet.save(saveFileDialog1.FileName);
            MessageBox.Show("File Saved");

        }

        private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog();

            if (spreadsheet.tryLoad(openFileDialog2.FileName))
            {
                spreadsheet.load(openFileDialog2.FileName);
                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();
                dataGridView.Refresh();
                for (int i = 0; i < spreadsheet.getCols(); i++)
                {
                    dataGridView.Columns.Add("", "");
                }
                for (int i = 0; i < spreadsheet.getRows() - 1; i++)
                {
                    dataGridView.Rows.Add();
                }
                for (int i = 0; i < spreadsheet.getRows(); i++)
                {
                    for (int j = 0; j < spreadsheet.getCols(); j++)
                    {
                        dataGridView[j, i].Value = spreadsheet.getCell(i, j);
                    }
                }
                MessageBox.Show("Load Succesfuly");
            }
            else
                MessageBox.Show("file not found");



        }

        private void newSpreadSheetToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            using (var form = new Form2())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int rowReturn = form.Returnrow;
                    int colReturn = form.Returncol;

                    this.Cols = colReturn;
                    this.Rows = rowReturn;
                    spreadsheet = new SharableSpreadSheet(Rows, Cols);
                }
            }
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Refresh();
            for (int i = 0; i < spreadsheet.getCols(); i++)
            {
                dataGridView.Columns.Add("", "");
            }
            for (int i = 0; i < spreadsheet.getRows() - 1; i++)
            {
                dataGridView.Rows.Add();
            }
        }

        private void addRow_Click(object sender, EventArgs e)
        {
            if(int.TryParse(addRow1.Text, out int addAfter))
            {
                spreadsheet.addRow(addAfter);
                updateGrid();
            }
            
        }

        private void addCol_Click(object sender, EventArgs e)
        {
            if (int.TryParse(addCol1.Text, out int addAfter))
            {
                spreadsheet.addCol(addAfter);
                updateGrid();
            }
        }

        private void updateGrid()
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Refresh();
            for (int i = 0; i < spreadsheet.getCols(); i++)
            {
                dataGridView.Columns.Add("", "");
            }
            for (int i = 0; i < spreadsheet.getRows() - 1; i++)
            {
                dataGridView.Rows.Add();
            }
            for (int i = 0; i < spreadsheet.getRows(); i++)
            {
                for (int j = 0; j < spreadsheet.getCols(); j++)
                {
                    dataGridView[j, i].Value = spreadsheet.getCell(i, j);
                }
            }
        }

        private void exRows_Click(object sender, EventArgs e)
        {
            if (int.TryParse(row1.Text, out int firstRow) && int.TryParse(row2.Text, out int secRow))
            {
                spreadsheet.exchangeRows(firstRow, secRow);
                updateGrid();
            }
        }

        private void exCols_Click(object sender, EventArgs e)
        {
            if (int.TryParse(col1.Text, out int firstCol) && int.TryParse(col2.Text, out int secCol))
            {
                spreadsheet.exchangeCols(firstCol, secCol);
                updateGrid();
            }
        }


        private void inRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new Form3())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string toSearch = form.stringTo;
                    int rowTosearchIn = form.row;
                    int col = spreadsheet.searchInRow(rowTosearchIn, toSearch);
                    if (col >= 0 && col < dataGridView.Columns.Count)
                    {
                        MessageBox.Show("Found in col: " + col);
                        dataGridView[rowTosearchIn, col].Style.BackColor = Color.Yellow;

                    }
                    else
                    {
                        MessageBox.Show("Not Found");
                    }
                }
            }
        }

        private void inColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new Form4())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string toSearch = form.stringTo;
                    int colTosearchIn = form.col;
                    int row = spreadsheet.searchInRow(colTosearchIn, toSearch);
                    if (row >= 0 && row < dataGridView.Columns.Count)
                    {
                        MessageBox.Show("Found in raw: " + row);
                        dataGridView[colTosearchIn, row].Style.BackColor = Color.Yellow;

                    }
                    else
                    {
                        MessageBox.Show("Not Found");
                    }
                }
            }
        }

        private void inRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new Form5())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string toSearch = form.stringTo;
                    int col1 = form.col1;
                    int col2 = form.col2;
                    int row1 = form.row1;
                    int row2 = form.row2;
                    Tuple<int, int> position = spreadsheet.searchInRange(row1, row2, col1, col2, toSearch);
                    if (position != null)
                    {
                        MessageBox.Show("Found in raw: " + position.Item1 + " col: " + position.Item2);
                        dataGridView[position.Item1, position.Item2].Style.BackColor = Color.Yellow;
                    }
                    else
                    {
                        MessageBox.Show("Not Found");
                    }
                }
            }
        }

        private void setCellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new SetCell())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string toSearch = form.stringTo;
                    int col = form.col;
                    int row = form.row;
                    spreadsheet.setCell(row, col, toSearch);
                    updateGrid();
                }
            }
        }

        private void getCellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new getCell())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int col = form.col;
                    int row = form.row;
                    MessageBox.Show("Found in raw: " + row + " col: " + col + " - " + spreadsheet.getCell(row, col));
                }
            }
        }

        private void allTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new search())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string toSearch = form.stringTo;

                    Tuple<int, int> position = spreadsheet.searchString(toSearch);
                    if (position != null)
                    {
                        MessageBox.Show("Found in raw: " + position.Item1 + " col: " + position.Item2);
                        dataGridView[position.Item1, position.Item2].Style.BackColor = Color.Yellow;
                    }
                    else
                    {
                        MessageBox.Show("Not Found");
                    }
                }
            }
        }
    }
    

}