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
        #region Declarations

        string CustomerName = String.Empty;
        int DeskWidth = 0;
        int DeskDepth = 0;
        int Drawers = 0;
        DesktopMaterial DesktopMaterial;
        int RushOrderDays = 0;
        int DeskQuoteTotal = 0;
        public AddQuote()
        {
            InitializeComponent();

            List<DesktopMaterial> DesktopMaterialList = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            DesktopMaterialComboBox.DataSource = DesktopMaterialList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var MainMenuForm = (MainMenu)Tag;
            MainMenuForm.Show();
            Close();
        }

        private void WidthTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(WidthTextBox.Text, out int WidthInput))
            {
                if (WidthInput < Desk.MINWIDTH || WidthInput > Desk.MAXWIDTH)
                {
                    MessageBox.Show("Please enter a width from 24 to 96 inches.");
                    WidthTextBox.Text = String.Empty;
                    WidthTextBox.BackColor = Color.Red;
                    WidthTextBox.Focus();
                }
                else
                {
                    WidthTextBox.BackColor = Color.White;
                }
            }
            else
            {
                MessageBox.Show("Thank you for entering the width.");
                WidthTextBox.Text = String.Empty;
                WidthTextBox.BackColor = Color.LightSalmon;
                WidthTextBox.Focus();

            }
            
        }
       

        private void DepthTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(DepthTextBox.Text, out int DepthInput))
            {
                if (DepthInput < Desk.MINDEPTH || DepthInput > Desk.MAXDEPTH)
                {
                    MessageBox.Show("Please enter a depth from 24 to 48 inches.");
                    DepthTextBox.Text = String.Empty;
                    DepthTextBox.BackColor = Color.Red;
                    DepthTextBox.Focus();
                }
                else
                {
                    DepthTextBox.BackColor = Color.White;
                }
            }
            else
            {
                MessageBox.Show("Thank you for entering the width.");
                DepthTextBox.Text = String.Empty;
                DepthTextBox.BackColor = Color.LightSalmon;
                DepthTextBox.Focus();

            }

        }

        private void Dimensions_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }        }


        private void AddQuote_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        {
private void AddDeskButton_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerName = customerNameTextBox.Text;
                DeskWidth = int.Parse(WidthTextBox.Text);
                DeskDepth = int.Parse(DepthTextBox.Text);
                Drawers = int.Parse(NumDrawersComboBox.SelectedItem.ToString());
                DesktopMaterial = (DesktopMaterial)DesktopMaterialComboBox.SelectedValue;

                if (RushThreeRadio.Checked)
                {
                    RushOrderDays = 3;
                }
                if (RushFiveRadio.Checked)
                {
                    RushOrderDays = 5;
                }
                if (RushSevenRadio.Checked)
                {
                    RushOrderDays = 7;
                }

                DeskQuote NewQuote = new DeskQuote(CustomerName, DateTime.Now, DeskWidth, DeskDepth, Drawers, DesktopMaterial, RushOrderDays);
                DeskQuoteTotal = NewQuote.CalculateQuoteTotal();

                var DeskRecord = CustomerName + "," + DateTime.Now + "," + DeskWidth + "," + DeskDepth + "," + Drawers + "," + DesktopMaterial + "," + RushOrderDays + "," + DeskQuoteTotal;

                string cFile = @"quotes.txt";
                if (!File.Exists(cFile))
                {
                    using (StreamWriter sw = FileDialog.CreateText(SearchQuotes.txt)) {}
                }
                using (StreamWriter swa = FileDialog.AppendText("quotes.txt")) { swa.WriteLine(DeskRecord); }

                DeskQuoteView NewOrderView = new DeskQuoteView(NewQuote);

                var MainMenu = (MainMenu)Tag;
                { Tag = MainMenu; };
                NewOrderView.Show(MainMenu);
                this.Close();

            }
            catch (Exception)
            {
                MessageBox.Show(Exception.Message);
                throw;
            }
        }
    }
    }
}
