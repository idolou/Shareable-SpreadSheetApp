namespace SpreadSheetApp
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.inRow = new System.Windows.Forms.Button();
            this.toSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(176, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Row";
            this.textBox1.Size = new System.Drawing.Size(54, 29);
            this.textBox1.TabIndex = 35;
            // 
            // inRow
            // 
            this.inRow.BackColor = System.Drawing.Color.LightSteelBlue;
            this.inRow.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inRow.Location = new System.Drawing.Point(-1, 42);
            this.inRow.Name = "inRow";
            this.inRow.Size = new System.Drawing.Size(231, 42);
            this.inRow.TabIndex = 36;
            this.inRow.Text = "Search In Row";
            this.inRow.UseVisualStyleBackColor = false;
            this.inRow.Click += new System.EventHandler(this.inRow_Click);
            // 
            // toSearch
            // 
            this.toSearch.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toSearch.Location = new System.Drawing.Point(-1, 7);
            this.toSearch.Multiline = true;
            this.toSearch.Name = "toSearch";
            this.toSearch.PlaceholderText = "Search";
            this.toSearch.Size = new System.Drawing.Size(162, 29);
            this.toSearch.TabIndex = 37;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(244, 87);
            this.Controls.Add(this.toSearch);
            this.Controls.Add(this.inRow);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button inRow;
        private TextBox toSearch;
    }
}