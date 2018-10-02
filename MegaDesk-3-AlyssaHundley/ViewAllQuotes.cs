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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var MainMenuForm = (MainMenu)Tag;
            MainMenuForm.Show();
            Close();
        }
    }
}
