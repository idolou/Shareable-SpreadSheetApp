using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Threading;
using System.Collections;
using System.IO;

namespace SpreadsheetApp
{
    internal class SharableSpreadSheet
    {
        private string[,] table;
        //private new List<List<string>> table = new List<List<string>>();
        private int nUser;
        private int nRows;
        private int nCols;
        private Mutex reader_mut; //Mutex for reader operations
        private Mutex writer_mut; //Mutex for writer operations
        private Mutex search_mut; //Mutex for search operations
        private Mutex structure_mut; //Mutex for table operations
        private Semaphore searchConCurrently_semaphore; //Semaphore for search operations
        private int readcount; //Counter for number of readers operations that run simultaneously
        private int writecount; //Counter for number of writers operations that run simultaneously
        private int searchcount; //Counter for number of search operations that run simultaneously
        private int searchLimit; //Counter for number of search operations that run simultaneously




        public SharableSpreadSheet(int nRows, int nCols, int nUsers = -1)
        {
            // nUsers used for setConcurrentSearchLimit, -1 mean no limit.
            // construct a nRows*nCols spreadsheet

            this.nUser = nUsers;
            this.nRows = nRows;
            this.nCols = nCols;
            this.table = new string[nRows, nCols];
            this.searchcount = 0;


            //init
            this.reader_mut = new Mutex();
            this.writer_mut = new Mutex();
            this.structure_mut = new Mutex();
            this.search_mut = new Mutex();
            if (nUsers == -1)
            {
                this.searchConCurrently_semaphore = null;
                this.searchLimit = 1000000;
            }
            else
            {
                this.searchConCurrently_semaphore = new Semaphore(nUsers, nUsers);
                this.searchLimit = nUser;
            }

            for (int i = 0; i < nRows; i++)
            {
                for (int j = 0; j < nCols; j++)
                {
                    table[i, j] = "";
                }
            }

        }
        public String getCell(int row, int col)
        {
            // return the string at [row,col]
            if (!inRange(row, col))
            {
                throw new Exception("Out of range");
            }
            //Monitor.Enter(table[row, col]);
            Object obj = table[row, col];
            Monitor.Enter(obj);
            string cellString = this.table[row, col];
            Monitor.Exit(obj);
            //Monitor.Exit(table[row, col]);
            return cellString;
        }
        public void setCell(int row, int col, String str)
        {
            // set the string at [row,col]
            if (!inRange(row, col))
            {
                throw new Exception("Out of range");
            }
            // Lock object
            Object obj = table[row, col];
            Monitor.Enter(obj);
            try
            {
                // Critical piece of code
                this.table[row, col] = str;
            }
            catch (SynchronizationLockException exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                // Releasing object
                Monitor.Exit(obj);
            }
            return;

        }
        public Tuple<int, int> searchString(String str)
        {
            int row, col;
            // return first cell indexes that contains the string (search from first row to the last row)
            enterSearchSem();
            {
                for (int rows = 0; rows < nRows; rows++)
                {
                    for (int cols = 0; cols < nCols; cols++)
                    {
                        //Monitor.Enter(table[rows, cols]);
                        if (str.Equals(this.table[rows, cols]))
                        {
                            //Monitor.Enter(table[rows, cols]);
                            Object obj = table[rows, cols];
                            Monitor.Enter(obj);
                            Tuple<int, int> indexx = new Tuple<int, int>(rows, cols);
                            Monitor.Exit(obj);
                            //Monitor.Exit(table[rows, cols]);
                            exitSearchSem();
                            exitReadMut();
                            return indexx;
                        }
                        //Monitor.Exit(table[rows, cols]);
                    }
                }
            }
            exitSearchSem();
            return null;
        }
        public void exchangeRows(int row1, int row2)
        {
            // exchange the content of row1 and row2

            if (!isRowInRange(row1) && !isRowInRange(row2))
            {
                throw new Exception("Out of range");
            }
            writer_mut.WaitOne();
            string[] temp_1 = new string[nCols];
            for (int i = 0; i < nCols; i++)
            {
                Monitor.Enter(table[row1, i]);
                Monitor.Enter(table[row2, i]);
                //Object obj1 = table[row1, i];
                //Object obj2 = table[row2, i];
                //Monitor.Enter(obj1);
                //Monitor.Enter(obj2);
                temp_1[i] = table[row1, i];
                table[row1, i] = table[row2, i];
                table[row2, i] = temp_1[i];
            }
            for (int i = 0; i < nCols; i++)
            {
                Monitor.Exit(table[row1, i]);
                Monitor.Exit(table[row2, i]);
            }
            writer_mut.ReleaseMutex();
        }

        public void exchangeCols(int col1, int col2)
        {
            // exchange the content of col1 and col2

            if (!isColInRange(col1) && !isColInRange(col2))
            {
                throw new Exception("Out of range");
            }

            writer_mut.WaitOne();
            string[] temp_1 = new string[nRows];
            for (int i = 0; i < nRows; i++)
            {
                Monitor.Enter(table[i, col1]);
                Monitor.Enter(table[i, col2]);
                temp_1[i] = table[i, col1];
                table[i, col1] = table[i, col2];
                table[i, col2] = temp_1[i];
            }
            for (int i = 0; i < nRows; i++)
            {
                Monitor.Exit(table[i, col1]);
                Monitor.Exit(table[i, col2]);
            }
            writer_mut.ReleaseMutex();
        }

        public int searchInRow(int row, String str)
        {
            int col = -1;
            // perform search in specific row

            if (!isRowInRange(row))
            {
                throw new Exception("Out of range");
            }
            enterSearchSem();

            for (col = 0; col < nCols; col++)
            {
                Monitor.Enter(table[row, col]);
                if (str.Equals(table[row, col]))
                {
                    Monitor.Exit(table[row, col]);
                    exitSearchSem();
                    return col;
                }
                Monitor.Exit(table[row, col]);
            }
            exitSearchSem();
            return col;
        }
        public int searchInCol(int col, String str)
        {
            int row = -1;
            // perform search in specific col

            if (!isColInRange(col))
            {
                throw new Exception("Out of range");
            }
            enterSearchSem();
            for (row = 0; row < nRows; row++)
            {
                Monitor.Enter(table[row, col]);
                if (str.Equals(table[row, col]))
                {
                    Monitor.Exit(table[row, col]);
                    exitSearchSem();
                    return row;
                }
                Monitor.Exit(table[row, col]);
            }
            exitSearchSem();
            return row;
        }
        public Tuple<int, int> searchInRange(int col1, int col2, int row1, int row2, String str)
        {
            // perform search within spesific range: [row1:row2,col1:col2] 
            //includes col1,col2,row1,row2
            int row, col;
            inRange(row1, col1);
            inRange(row2, col2);

            enterSearchSem();
            if (col1 <= col2 && row1 <= row2)
            {
                for (row = row1; row < row2; row++)
                {
                    for (col = col1; col < col2; col++)
                    {
                        Monitor.Enter(table[row, col]);
                        if (str.Equals(table[row, col]))
                        {
                            Tuple<int, int> tuple = new Tuple<int, int>(row, col);
                            Monitor.Exit(table[row, col]);
                            exitSearchSem();
                            return tuple;
                        }
                        Monitor.Exit(table[row, col]);
                    }
                }
            }
            exitSearchSem();
            return null;

        }
        public void addRow(int row1)
        {
            //add a row after row1
            if (!isRowInRange(row1))
            {
                throw new Exception("Out of range");
            }
            writer_mut.WaitOne();
            //create new table
            string[,] temp_table = new string[nRows + 1, nCols];
            // copy everthing untill row 1
            for (int row = 0; row <= row1; row++)
            {
                for (int col = 0; col < nCols; col++)
                {
                    Monitor.Enter(table[row, col]);
                    temp_table[row, col] = table[row, col];
                    Monitor.Exit(table[row, col]);
                }
            }

            //nRows++;


            //fill with empty string the new row
            for (int col = 0; col < nCols; col++)
            {
                temp_table[row1 + 1, col] = "";
            }
            // copy the oringal after the new row
            for (int row = row1 + 1; row < nRows; row++)
            {
                for (int col = 0; col < nCols; col++)
                {
                    Monitor.Enter(table[row, col]);
                    temp_table[row + 1, col] = table[row, col];
                    Monitor.Exit(table[row, col]);
                }
            }
            this.table = temp_table;
            nRows++;
            writer_mut.ReleaseMutex();
            return;
        }
        public void addCol(int col1)
        {
            //add a column after col1


            if (!isColInRange(col1))
            {
                throw new Exception("Out of range");
            }
            writer_mut.WaitOne();
            //create new table
            string[,] temp_table = new string[nRows, nCols + 1];
            // copy everthing untill row 1-
            for (int row = 0; row < nRows; row++)
            {
                for (int col = 0; col <= col1; col++)
                {
                    Monitor.Enter(table[row, col]);
                    temp_table[row, col] = table[row, col];
                    Monitor.Exit(table[row, col]);
                }
            }
            //nCols++;
            //fill with empty string the new row
            for (int row = 0; row < nRows; row++)
            {
                temp_table[row, col1 + 1] = "";
            }
            // copy the oringal after the new row
            for (int row = 0; row < nRows; row++)
            {
                for (int col = col1 + 1; col < nCols; col++)
                {
                    Monitor.Enter(table[row, col]);
                    temp_table[row, col + 1] = table[row, col];
                    Monitor.Exit(table[row, col]);
                }
            }
            this.table = temp_table;
            nCols++;
            writer_mut.ReleaseMutex();
            return;
        }
        public Tuple<int, int>[] findAll(String str, bool caseSensitive)
        {
            // perform search and return all relevant cells according to caseSensitive param
            enterSearchSem();
            List<Tuple<int, int>> list = new List<Tuple<int, int>>();
            if (caseSensitive == true)
            {
                for (int row = 0; row < nRows; row++)
                {
                    for (int col = 0; col < nCols; col++)
                    {
                        if (str.Equals(table[row, col]))
                        {
                            Monitor.Enter(table[row, col]);
                            list.Add(new Tuple<int, int>(row, col));
                            Monitor.Exit(table[row, col]);
                        }
                    }
                }
                Tuple<int, int>[] tupleIndex = list.ToArray();
                exitSearchSem();
                return tupleIndex;
            }
            else
            {
                for (int row = 0; row < nRows; row++)
                {
                    for (int col = 0; col < nCols; col++)
                    {
                        if (str.ToLower().Equals(table[row, col].ToLower()))
                        {
                            Monitor.Enter(table[row, col]);
                            list.Add(new Tuple<int, int>(row, col));
                            Monitor.Exit(table[row, col]);
                        }
                    }
                }
                Tuple<int, int>[] tupleIndex = list.ToArray();
                exitSearchSem();
                return tupleIndex;
            }
        }


        public void setAll(String oldStr, String newStr, bool caseSensitive)
        {
            // replace all oldStr cells with the newStr str according to caseSensitive param
            //writer_mut.WaitOne();
            if (caseSensitive == true)
            {
                for (int row = 0; row < nRows; row++)
                {
                    for (int col = 0; col < nCols; col++)
                    {
                        if (oldStr.Equals(table[row, col]))
                        {
                            Object obj = table[row, col];
                            Monitor.Enter(obj);
                            //Monitor.Enter(table[row, col]);
                            table[row, col] = newStr;
                            Monitor.Exit(obj);
                            //Monitor.Exit(table[row, col]);
                        }
                    }
                }
            }
            else
            {
                for (int row = 0; row < nRows; row++)
                {
                    for (int col = 0; col < nCols; col++)
                    {
                        if (oldStr.ToLower().Equals(table[row, col].ToLower()))
                        {
                            Object obj = table[row, col];
                            Monitor.Enter(obj);
                            //Monitor.Enter(table[row, col]);
                            table[row, col] = newStr;
                            Monitor.Exit(obj);
                            //Monitor.Exit(table[row, col]);
                        }
                    }
                }
            }
            //writer_mut.ReleaseMutex();
        }

        //old set all
        /*    public void setAll(String oldStr, String newStr, bool caseSensitive)
            {
                // replace all oldStr cells with the newStr str according to caseSensitive param
                Tuple<int, int>[] tupleIndex = findAll(oldStr, caseSensitive);
                enterWriteMut();
                for (int i = 0; i < tupleIndex.Length; i++)
                {
                    object obj = table[tupleIndex[i].Item1, tupleIndex[i].Item2];
                    Monitor.Enter(obj);
                    table[tupleIndex[i].Item1, tupleIndex[i].Item2] = newStr;
                    Monitor.Exit(obj);
                }
                exitWriteMut();
            }*/
        public Tuple<int, int> getSize()
        {
            // return the size of the spreadsheet in nRows, nCols
            Tuple<int, int> tuple = new Tuple<int, int>(nRows, nCols);
            return tuple;

        }
        public void setConcurrentSearchLimit(int nUsers)
        {
            // this function aims to limit the number of users that can perform the search operations concurrently.
            // The default is no limit. When the function is called, the max number of concurrent search operations is set to nUsers. 
            // In this case additional search operations will wait for existing search to finish.
            // This function is used just in the creation

            //no limits in the  beginning 
            enterStructureMut();
            this.nUser = nUsers;
            searchConCurrently_semaphore = new Semaphore(nUsers, nUsers);
            exitStructureMut();
            return;
        }

        public void save(String fileName)
        {
            // save the spreadsheet to a file fileName.
            // you can decide the format you save the data. There are several options.


            enterStructureMut();

            //Entry_section_structure();
            string path = fileName;

            //Make sure the file is overwritten if it exists
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            //Create a new file and appends each cell in UTF-8 encoding
            using (StreamWriter sw = File.AppendText(path))
            {
                //Saves the meta data of the table (row and col size)
                sw.WriteLine(this.nRows);
                sw.WriteLine(this.nCols);

                for (int i = 0; i < this.nRows; i++)
                {
                    for (int j = 0; j < this.nCols; j++)
                    {
                        sw.WriteLine(this.table[i, j]);
                    }
                }
            }

            exitStructureMut();
        }

        public bool tryLoad(String fileName)
        {
            if (fileName == null)
                return false;
            return File.Exists(fileName);
        }

        public void load(String fileName)
        {
            // load the spreadsheet from fileName
            // replace the data and size of the current spreadsheet with the loaded data

            //Checks if path is legal

            enterStructureMut();
            if (!tryLoad(fileName))
            {
                //Exit_section_structure();
                return;
            }

            String path = fileName;
            int row, col;

            //Extracts data from the file
            using (StreamReader sr = new StreamReader(path))
            {
                //Extracts row and column sizes. Creates a new empty grid with matching sizes
                row = Int32.Parse(sr.ReadLine());
                col = Int32.Parse(sr.ReadLine());
                String[,] new_table = new String[row, col];

                //Updates the rows, cols and grid to the new values
                this.nRows = row;
                this.nCols = col;
                this.table = new_table;

                //Extracts the table data and assigns it to the new table
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        this.table[i, j] = sr.ReadLine();
                    }
                }
            }
            exitStructureMut();
            return;
        }


        //************************************************
        // our helpers func

        public int getRows()
        {
            return nRows;
        }

        public int getCols()
        {
            return nCols;
        }

        public bool inRange(int row, int col)
        {
            return (row < nRows && col < nCols && row >= 0 && col >= 0);
        }

        public bool isRowInRange(int row)
        {
            return (row < nRows && row >= 0);
        }

        public bool isColInRange(int col)
        {
            return (col < nRows && col >= 0);
        }


        public void enterReadMut()
        {
            this.reader_mut.WaitOne();
            readcount++;
            this.reader_mut.ReleaseMutex();
        }

        public void exitReadMut()
        {
            this.reader_mut.WaitOne();
            readcount--;
            this.reader_mut.ReleaseMutex();
        }

        public void enterWriteMut()
        {
            this.writer_mut.WaitOne();
            writecount++;
            this.writer_mut.ReleaseMutex();
        }

        public void exitWriteMut()
        {
            this.writer_mut.WaitOne();
            writecount--;
            this.writer_mut.ReleaseMutex();
        }

        public void enterSearchSem()
        {
            if (searchConCurrently_semaphore != null)
            {
                this.searchConCurrently_semaphore.WaitOne();
                searchcount++;
            }
        }

        public void exitSearchSem()
        {
            if (searchConCurrently_semaphore != null)
            {
                searchcount--;
                this.searchConCurrently_semaphore.Release();
            }
        }

        public void enterStructureMut()
        {
            this.reader_mut.WaitOne();
            this.writer_mut.WaitOne();
            this.structure_mut.WaitOne();
        }

        public void exitStructureMut()
        {
            this.structure_mut.ReleaseMutex();
            this.writer_mut.ReleaseMutex();
            this.reader_mut.ReleaseMutex();
        }



        public void printSheet()
        {
            for (int i = 0; i < nRows; i++)
            {
                for (int j = 0; j < nCols; j++)
                {
                    Console.Write(table[i, j] + " ");
                }
                Console.Write("\n");
            }

        }

    }




}


