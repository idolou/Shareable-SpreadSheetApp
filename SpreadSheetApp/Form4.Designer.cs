namespace SpreadSheetApp
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.toSearch = new System.Windows.Forms.TextBox();
            this.inCol = new System.Windows.Forms.Button();
            this.Coltext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toSearch
            // 
            this.toSearch.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toSearch.Location = new System.Drawing.Point(10, 11);
            this.toSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.toSearch.Multiline = true;
            this.toSearch.Name = "toSearch";
            this.toSearch.PlaceholderText = "Search";
            this.toSearch.Size = new System.Drawing.Size(114, 28);
            this.toSearch.TabIndex = 40;
            // 
            // inCol
            // 
            this.inCol.BackColor = System.Drawing.Color.LightSteelBlue;
            this.inCol.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inCol.Location = new System.Drawing.Point(10, 52);
            this.inCol.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inCol.Name = "inCol";
            this.inCol.Size = new System.Drawing.Size(211, 49);
            this.inCol.TabIndex = 39;
            this.inCol.Text = "Search In Column";
            this.inCol.UseVisualStyleBackColor = false;
            this.inCol.Click += new System.EventHandler(this.inCol_Click);
            // 
            // Coltext
            // 
            this.Coltext.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Coltext.Location = new System.Drawing.Point(151, 12);
            this.Coltext.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Coltext.Multiline = true;
            this.Coltext.Name = "Coltext";
            this.Coltext.PlaceholderText = "Col";
            this.Coltext.Size = new System.Drawing.Size(70, 28);
            this.Coltext.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(127, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "In";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(256, 125);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toSearch);
            this.Controls.Add(this.inCol);
            this.Controls.Add(this.Coltext);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox toSearch;
        private Button inCol;
        private TextBox Coltext;
        private Label label2;
    }
}