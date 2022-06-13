namespace SpreadSheetApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSpreadSheetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getCellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setCellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.addRow = new System.Windows.Forms.Button();
            this.addCol = new System.Windows.Forms.Button();
            this.addRow1 = new System.Windows.Forms.TextBox();
            this.addCol1 = new System.Windows.Forms.TextBox();
            this.row1 = new System.Windows.Forms.TextBox();
            this.exRows = new System.Windows.Forms.Button();
            this.row2 = new System.Windows.Forms.TextBox();
            this.col2 = new System.Windows.Forms.TextBox();
            this.col1 = new System.Windows.Forms.TextBox();
            this.exCols = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSlateGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "SpreadSheetApp";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.menuStrip1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.editToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1369, 34);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSpreadSheetToolStripMenuItem1,
            this.loadToolStripMenuItem1,
            this.saveToolStripMenuItem1});
            this.loadToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(46, 28);
            this.loadToolStripMenuItem.Text = "File";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // newSpreadSheetToolStripMenuItem1
            // 
            this.newSpreadSheetToolStripMenuItem1.Name = "newSpreadSheetToolStripMenuItem1";
            this.newSpreadSheetToolStripMenuItem1.Size = new System.Drawing.Size(204, 28);
            this.newSpreadSheetToolStripMenuItem1.Text = "New SpreadSheet";
            this.newSpreadSheetToolStripMenuItem1.Click += new System.EventHandler(this.newSpreadSheetToolStripMenuItem1_Click);
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(204, 28);
            this.loadToolStripMenuItem1.Text = "Load";
            this.loadToolStripMenuItem1.Click += new System.EventHandler(this.loadToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(204, 28);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getCellToolStripMenuItem,
            this.setCellToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 28);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // getCellToolStripMenuItem
            // 
            this.getCellToolStripMenuItem.Name = "getCellToolStripMenuItem";
            this.getCellToolStripMenuItem.Size = new System.Drawing.Size(132, 28);
            this.getCellToolStripMenuItem.Text = "Get cell";
            this.getCellToolStripMenuItem.Click += new System.EventHandler(this.getCellToolStripMenuItem_Click);
            // 
            // setCellToolStripMenuItem
            // 
            this.setCellToolStripMenuItem.Name = "setCellToolStripMenuItem";
            this.setCellToolStripMenuItem.Size = new System.Drawing.Size(132, 28);
            this.setCellToolStripMenuItem.Text = "Set cell";
            this.setCellToolStripMenuItem.Click += new System.EventHandler(this.setCellToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inRowToolStripMenuItem,
            this.inColumnToolStripMenuItem,
            this.inRangeToolStripMenuItem,
            this.allTableToolStripMenuItem});
            this.searchToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(71, 28);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // inRowToolStripMenuItem
            // 
            this.inRowToolStripMenuItem.Name = "inRowToolStripMenuItem";
            this.inRowToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.inRowToolStripMenuItem.Text = "In Row";
            this.inRowToolStripMenuItem.Click += new System.EventHandler(this.inRowToolStripMenuItem_Click);
            // 
            // inColumnToolStripMenuItem
            // 
            this.inColumnToolStripMenuItem.Name = "inColumnToolStripMenuItem";
            this.inColumnToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.inColumnToolStripMenuItem.Text = "In Column";
            this.inColumnToolStripMenuItem.Click += new System.EventHandler(this.inColumnToolStripMenuItem_Click);
            // 
            // inRangeToolStripMenuItem
            // 
            this.inRangeToolStripMenuItem.Name = "inRangeToolStripMenuItem";
            this.inRangeToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.inRangeToolStripMenuItem.Text = "In Range";
            this.inRangeToolStripMenuItem.Click += new System.EventHandler(this.inRangeToolStripMenuItem_Click);
            // 
            // allTableToolStripMenuItem
            // 
            this.allTableToolStripMenuItem.Name = "allTableToolStripMenuItem";
            this.allTableToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.allTableToolStripMenuItem.Text = "All Table";
            this.allTableToolStripMenuItem.Click += new System.EventHandler(this.allTableToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView.Location = new System.Drawing.Point(0, 95);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(921, 625);
            this.dataGridView.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // addRow
            // 
            this.addRow.BackColor = System.Drawing.Color.LightSteelBlue;
            this.addRow.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addRow.Location = new System.Drawing.Point(1166, 108);
            this.addRow.Margin = new System.Windows.Forms.Padding(5);
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(153, 43);
            this.addRow.TabIndex = 11;
            this.addRow.Text = "Add Row";
            this.addRow.UseVisualStyleBackColor = false;
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // addCol
            // 
            this.addCol.BackColor = System.Drawing.Color.LightSteelBlue;
            this.addCol.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCol.Location = new System.Drawing.Point(1166, 198);
            this.addCol.Margin = new System.Windows.Forms.Padding(5);
            this.addCol.Name = "addCol";
            this.addCol.Size = new System.Drawing.Size(153, 39);
            this.addCol.TabIndex = 12;
            this.addCol.Text = "Add Col";
            this.addCol.UseVisualStyleBackColor = false;
            this.addCol.Click += new System.EventHandler(this.addCol_Click);
            // 
            // addRow1
            // 
            this.addRow1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addRow1.Location = new System.Drawing.Point(1002, 113);
            this.addRow1.Margin = new System.Windows.Forms.Padding(5);
            this.addRow1.Multiline = true;
            this.addRow1.Name = "addRow1";
            this.addRow1.PlaceholderText = "Rows";
            this.addRow1.Size = new System.Drawing.Size(154, 32);
            this.addRow1.TabIndex = 13;
            this.addRow1.Enter += new System.EventHandler(this.addRow_Click);
            // 
            // addCol1
            // 
            this.addCol1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCol1.Location = new System.Drawing.Point(1002, 203);
            this.addCol1.Margin = new System.Windows.Forms.Padding(5);
            this.addCol1.Multiline = true;
            this.addCol1.Name = "addCol1";
            this.addCol1.PlaceholderText = "Columns";
            this.addCol1.Size = new System.Drawing.Size(154, 34);
            this.addCol1.TabIndex = 14;
            this.addCol1.Enter += new System.EventHandler(this.addCol_Click);
            // 
            // row1
            // 
            this.row1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.row1.Location = new System.Drawing.Point(1010, 362);
            this.row1.Margin = new System.Windows.Forms.Padding(5);
            this.row1.Name = "row1";
            this.row1.PlaceholderText = "Row1";
            this.row1.Size = new System.Drawing.Size(118, 29);
            this.row1.TabIndex = 17;
            // 
            // exRows
            // 
            this.exRows.BackColor = System.Drawing.Color.LightSteelBlue;
            this.exRows.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exRows.Location = new System.Drawing.Point(1002, 301);
            this.exRows.Margin = new System.Windows.Forms.Padding(5);
            this.exRows.Name = "exRows";
            this.exRows.Size = new System.Drawing.Size(319, 53);
            this.exRows.TabIndex = 15;
            this.exRows.Text = "Exchange Rows";
            this.exRows.UseVisualStyleBackColor = false;
            this.exRows.Click += new System.EventHandler(this.exRows_Click);
            // 
            // row2
            // 
            this.row2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.row2.Location = new System.Drawing.Point(1207, 364);
            this.row2.Margin = new System.Windows.Forms.Padding(5);
            this.row2.Name = "row2";
            this.row2.PlaceholderText = "Row2";
            this.row2.Size = new System.Drawing.Size(114, 29);
            this.row2.TabIndex = 19;
            // 
            // col2
            // 
            this.col2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.col2.Location = new System.Drawing.Point(1207, 504);
            this.col2.Margin = new System.Windows.Forms.Padding(5);
            this.col2.Name = "col2";
            this.col2.PlaceholderText = "Col2";
            this.col2.Size = new System.Drawing.Size(112, 29);
            this.col2.TabIndex = 22;
            // 
            // col1
            // 
            this.col1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.col1.Location = new System.Drawing.Point(1010, 503);
            this.col1.Margin = new System.Windows.Forms.Padding(5);
            this.col1.Name = "col1";
            this.col1.PlaceholderText = "Col1";
            this.col1.Size = new System.Drawing.Size(116, 29);
            this.col1.TabIndex = 21;
            // 
            // exCols
            // 
            this.exCols.BackColor = System.Drawing.Color.LightSteelBlue;
            this.exCols.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exCols.Location = new System.Drawing.Point(1002, 445);
            this.exCols.Margin = new System.Windows.Forms.Padding(5);
            this.exCols.Name = "exCols";
            this.exCols.Size = new System.Drawing.Size(317, 49);
            this.exCols.TabIndex = 20;
            this.exCols.Text = "Exchange Cols";
            this.exCols.UseVisualStyleBackColor = false;
            this.exCols.Click += new System.EventHandler(this.exCols_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1148, 365);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "with";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1146, 506);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "with";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1369, 720);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.col2);
            this.Controls.Add(this.col1);
            this.Controls.Add(this.exCols);
            this.Controls.Add(this.row2);
            this.Controls.Add(this.row1);
            this.Controls.Add(this.exRows);
            this.Controls.Add(this.addCol1);
            this.Controls.Add(this.addRow1);
            this.Controls.Add(this.addCol);
            this.Controls.Add(this.addRow);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.Text = "Sheets";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private ToolStripMenuItem newSpreadSheetToolStripMenuItem1;
        private DataGridView dataGridView;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem loadToolStripMenuItem1;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private BindingSource bindingSource1;
        private BindingSource bindingSource2;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private Button addRow;
        private Button addCol;
        private TextBox addRow1;
        private TextBox addCol1;
        private TextBox row1;
        private Button exRows;
        private TextBox row2;
        private TextBox col2;
        private TextBox col1;
        private Button exCols;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem inRowToolStripMenuItem;
        private ToolStripMenuItem inColumnToolStripMenuItem;
        private ToolStripMenuItem inRangeToolStripMenuItem;
        private Label label2;
        private Label label3;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem getCellToolStripMenuItem;
        private ToolStripMenuItem setCellToolStripMenuItem;
        private ToolStripMenuItem allTableToolStripMenuItem;
    }
}