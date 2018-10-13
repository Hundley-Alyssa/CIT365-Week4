namespace MegaDesk_3_AlyssaHundley
{
    partial class SearchQuotes
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
            this.label1 = new System.Windows.Forms.Label();
            this.SearchByMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.SearchResultsListView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by Material Type";
            // 
            // SearchByMaterialComboBox
            // 
            this.SearchByMaterialComboBox.FormattingEnabled = true;
            this.SearchByMaterialComboBox.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.SearchByMaterialComboBox.Location = new System.Drawing.Point(227, 26);
            this.SearchByMaterialComboBox.Name = "SearchByMaterialComboBox";
            this.SearchByMaterialComboBox.Size = new System.Drawing.Size(121, 21);
            this.SearchByMaterialComboBox.TabIndex = 1;
            // 
            // SearchResultsListView
            // 
            this.SearchResultsListView.Location = new System.Drawing.Point(30, 98);
            this.SearchResultsListView.Name = "SearchResultsListView";
            this.SearchResultsListView.Size = new System.Drawing.Size(496, 237);
            this.SearchResultsListView.TabIndex = 2;
            this.SearchResultsListView.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 398);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchResultsListView);
            this.Controls.Add(this.SearchByMaterialComboBox);
            this.Controls.Add(this.label1);
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SearchByMaterialComboBox;
        private System.Windows.Forms.ListView SearchResultsListView;
        private System.Windows.Forms.Button button1;
    }
}