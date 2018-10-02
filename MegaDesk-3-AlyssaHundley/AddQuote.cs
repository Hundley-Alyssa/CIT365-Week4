using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_AlyssaHundley
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var MainMenuForm = (MainMenu)Tag;
            MainMenuForm.Show();
            Close();
        }

        private void WidthTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(int.TryParse(WidthTextBox.Text, out int WidthInput))
            {
                if(WidthInput < Desk.MINWIDTH || WidthInput > Desk.MAXWIDTH)
                {
                    MessageBox.Show("Please enter a width from 24 to 96 inches.");
                    WidthTextBox.Text = String.Empty;
                    WidthTextBox.BackColor = Color.Red;
                    WidthTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("Thank you for entering the width.");
                    WidthTextBox.Text = String.Empty;
                    WidthTextBox.BackColor = Color.White;
                    WidthTextBox.Focus();

                }
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HeightTextBoxPress(object sender, KeyPressEventArgs e)
        {

           char.IsDigit(e.KeyChar);
        }
    }
}
