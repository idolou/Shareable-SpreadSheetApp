namespace SpreadSheetApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.rowstextBox = new System.Windows.Forms.TextBox();
            this.colsTextBox = new System.Windows.Forms.TextBox();
            this.addbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rowstextBox
            // 
            this.rowstextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rowstextBox.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rowstextBox.Location = new System.Drawing.Point(11, 4);
            this.rowstextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rowstextBox.Multiline = true;
            this.rowstextBox.Name = "rowstextBox";
            this.rowstextBox.PlaceholderText = "Rows number";
            this.rowstextBox.Size = new System.Drawing.Size(85, 23);
            this.rowstextBox.TabIndex = 0;
            // 
            // colsTextBox
            // 
            this.colsTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.colsTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colsTextBox.Location = new System.Drawing.Point(11, 34);
            this.colsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.colsTextBox.Multiline = true;
            this.colsTextBox.Name = "colsTextBox";
            this.colsTextBox.PlaceholderText = "Columns number";
            this.colsTextBox.Size = new System.Drawing.Size(85, 24);
            this.colsTextBox.TabIndex = 1;
            // 
            // addbutton1
            // 
            this.addbutton1.BackColor = System.Drawing.Color.SeaGreen;
            this.addbutton1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addbutton1.Location = new System.Drawing.Point(106, 7);
            this.addbutton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addbutton1.Name = "addbutton1";
            this.addbutton1.Size = new System.Drawing.Size(82, 47);
            this.addbutton1.TabIndex = 2;
            this.addbutton1.Text = "Add";
            this.addbutton1.UseVisualStyleBackColor = false;
            this.addbutton1.Click += new System.EventHandler(this.addbutton1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(207, 69);
            this.Controls.Add(this.addbutton1);
            this.Controls.Add(this.colsTextBox);
            this.Controls.Add(this.rowstextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "New SpreadSheet";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox rowstextBox;
        private TextBox colsTextBox;
        private Button addbutton1;
    }
}