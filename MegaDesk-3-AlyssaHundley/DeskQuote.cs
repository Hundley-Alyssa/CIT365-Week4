using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_AlyssaHundley
{
    class DeskQuote
    {
        private string CustomerName;
        private DateTime QuoteDate;
    
        private Desk Desk = new Desk();


        private const int PRICE_BASE = 200;
      


        public DeskQuote(int width, int depth, int drawers, string material, int rushDays)
        {
            Desk.Width = width;
        }

        public int CalculateQuoteTotal()
        {
            return PRICE_BASE;
        }
       

    }

}
