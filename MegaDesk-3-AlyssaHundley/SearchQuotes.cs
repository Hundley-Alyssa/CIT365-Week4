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
    public partial class SearchQuotes : Form
    {
        private const string QUOTEFILE = @"quotes.txt";
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            SearchByMaterialComboBox.DataSource = Enum.GetNames(typeof(DesktopMaterial));
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchResultsListView.Clear();
            try
            {
                string MaterialSelected = SearchByMaterialComboBox.SelectedItem.ToString();

                if (!File.Exists(QUOTEFILE))
                {
                    MessageBox.Show("A quote file was not found in the application root", "Error Reading File");

                }
                else
                {
                    SearchResultsListView.Columns.Add("#", 30, HorizontalAlignment.Center);
                    SearchResultsListView.Columns.Add("Name", 170, HorizontalAlignment.Center);
                    SearchResultsListView.Columns.Add("Date", 180, HorizontalAlignment.Center);
                    SearchResultsListView.Columns.Add("Width", 70, HorizontalAlignment.Center);
                    SearchResultsListView.Columns.Add("Depth", 70, HorizontalAlignment.Center);
                    SearchResultsListView.Columns.Add("Drawers", 80, HorizontalAlignment.Center);
                    SearchResultsListView.Columns.Add("Desktop", 120, HorizontalAlignment.Center);
                    SearchResultsListView.Columns.Add("Days", 70, HorizontalAlignment.Center);
                    SearchResultsListView.Columns.Add("Total", 170, HorizontalAlignment.Center);

                    using(StreamReader sr = new StreamReader(QUOTEFILE))
                    {
                        int quoteCount = 0;
                        while (!sr.EndOfStream)
                        {
                            string[] fieldvalue = sr.ReadLine().Split(',');
                            if (fieldvalue[5] == MaterialSelected)
                            {
                                quoteCount++;
                                SearchResultsListView.Items.Add(new ListViewItem(new[] { quoteCount.ToString(), fieldvalue[0], fieldvalue[1], fieldvalue[2], fieldvalue[3], fieldvalue[4], fieldvalue[5], fieldvalue[6], "$" + fieldvalue[7] }));
                            }
                        }
                    };


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error with populating ListView using StreamReader." + "\n\n" + ex);
                throw;
            }
        }
    }
}
