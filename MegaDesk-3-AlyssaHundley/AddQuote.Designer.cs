namespace MegaDesk_3_AlyssaHundley
{
    partial class AddQuote
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
            this.button1 = new System.Windows.Forms.Button();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DepthTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NumDrawersComboBox = new System.Windows.Forms.ComboBox();
            this.DesktopMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.RushThreeRadio = new System.Windows.Forms.RadioButton();
            this.RushFiveRadio = new System.Windows.Forms.RadioButton();
            this.RushSevenRadio = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(62, 112);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTextBox.TabIndex = 1;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            this.WidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dimensions_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Width";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // DepthTextBox
            // 
            this.DepthTextBox.Location = new System.Drawing.Point(62, 157);
            this.DepthTextBox.Name = "DepthTextBox";
            this.DepthTextBox.Size = new System.Drawing.Size(100, 20);
            this.DepthTextBox.TabIndex = 5;
            this.DepthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dimensions_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Depth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add Desk Quote";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(62, 69);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerNameTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Drawers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Desktop";
            // 
            // NumDrawersComboBox
            // 
            this.NumDrawersComboBox.FormattingEnabled = true;
            this.NumDrawersComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.NumDrawersComboBox.Location = new System.Drawing.Point(41, 197);
            this.NumDrawersComboBox.Name = "NumDrawersComboBox";
            this.NumDrawersComboBox.Size = new System.Drawing.Size(121, 21);
            this.NumDrawersComboBox.TabIndex = 12;
            // 
            // DesktopMaterialComboBox
            // 
            this.DesktopMaterialComboBox.FormattingEnabled = true;
            this.DesktopMaterialComboBox.Location = new System.Drawing.Point(41, 235);
            this.DesktopMaterialComboBox.Name = "DesktopMaterialComboBox";
            this.DesktopMaterialComboBox.Size = new System.Drawing.Size(121, 21);
            this.DesktopMaterialComboBox.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Get Quote";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddDeskButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(338, 97);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "None";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // RushThreeRadio
            // 
            this.RushThreeRadio.AutoSize = true;
            this.RushThreeRadio.Location = new System.Drawing.Point(338, 130);
            this.RushThreeRadio.Name = "RushThreeRadio";
            this.RushThreeRadio.Size = new System.Drawing.Size(31, 17);
            this.RushThreeRadio.TabIndex = 16;
            this.RushThreeRadio.TabStop = true;
            this.RushThreeRadio.Text = "3";
            this.RushThreeRadio.UseVisualStyleBackColor = true;
            // 
            // RushFiveRadio
            // 
            this.RushFiveRadio.AutoSize = true;
            this.RushFiveRadio.Location = new System.Drawing.Point(338, 163);
            this.RushFiveRadio.Name = "RushFiveRadio";
            this.RushFiveRadio.Size = new System.Drawing.Size(31, 17);
            this.RushFiveRadio.TabIndex = 17;
            this.RushFiveRadio.TabStop = true;
            this.RushFiveRadio.Text = "5";
            this.RushFiveRadio.UseVisualStyleBackColor = true;
            // 
            // RushSevenRadio
            // 
            this.RushSevenRadio.AutoSize = true;
            this.RushSevenRadio.Location = new System.Drawing.Point(338, 197);
            this.RushSevenRadio.Name = "RushSevenRadio";
            this.RushSevenRadio.Size = new System.Drawing.Size(31, 17);
            this.RushSevenRadio.TabIndex = 18;
            this.RushSevenRadio.TabStop = true;
            this.RushSevenRadio.Text = "7";
            this.RushSevenRadio.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Rush Days";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 295);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RushSevenRadio);
            this.Controls.Add(this.RushFiveRadio);
            this.Controls.Add(this.RushThreeRadio);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DesktopMaterialComboBox);
            this.Controls.Add(this.NumDrawersComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DepthTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.button1);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dimensions_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DepthTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox NumDrawersComboBox;
        private System.Windows.Forms.ComboBox DesktopMaterialComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton RushThreeRadio;
        private System.Windows.Forms.RadioButton RushFiveRadio;
        private System.Windows.Forms.RadioButton RushSevenRadio;
        private System.Windows.Forms.Label label8;
    }
}