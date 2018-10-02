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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddQuote AddQuoteForm = new AddQuote { Tag = this };
            AddQuoteForm.Show(this);
            Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewAllQuotes ViewAllQuotesForm = new ViewAllQuotes { Tag = this };
            ViewAllQuotesForm.Show(this);
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchQuotes SearchQuotesForm = new SearchQuotes { Tag = this };
            SearchQuotesForm.Show(this);
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }
    }
}
