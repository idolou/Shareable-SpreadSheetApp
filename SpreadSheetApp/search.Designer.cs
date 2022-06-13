namespace SpreadSheetApp
{
    partial class search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search));
            this.toSearch = new System.Windows.Forms.TextBox();
            this.inCol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toSearch
            // 
            this.toSearch.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toSearch.Location = new System.Drawing.Point(9, 26);
            this.toSearch.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.toSearch.Multiline = true;
            this.toSearch.Name = "toSearch";
            this.toSearch.PlaceholderText = "Value";
            this.toSearch.Size = new System.Drawing.Size(81, 32);
            this.toSearch.TabIndex = 57;
            // 
            // inCol
            // 
            this.inCol.BackColor = System.Drawing.Color.LightSteelBlue;
            this.inCol.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inCol.Location = new System.Drawing.Point(95, 25);
            this.inCol.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.inCol.Name = "inCol";
            this.inCol.Size = new System.Drawing.Size(111, 35);
            this.inCol.TabIndex = 56;
            this.inCol.Text = "Search";
            this.inCol.UseVisualStyleBackColor = false;
            this.inCol.Click += new System.EventHandler(this.inCol_Click);
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(239, 87);
            this.Controls.Add(this.toSearch);
            this.Controls.Add(this.inCol);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "search";
            this.Text = "search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox toSearch;
        private Button inCol;
    }
}