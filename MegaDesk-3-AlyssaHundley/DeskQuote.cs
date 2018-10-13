using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_AlyssaHundley
{
    class DeskQuote
    {
        public string CustomerName;
        public DateTime QuoteDate;
        public int RushDays { get; set; }
        public Desk Desk = new Desk();
        public int QuoteAmount { get; set; }

        
        private int SurfaceArea = 0;

        private const int PRICE_BASE = 200;
        private const int SIZE_THRESHOLD = 1000;
        private const int PRICE_PER_DRAWER = 50;
        private const int PRICE_PER_SURFACEAREA = 1;
        private const int RUSH1 = 3;
        private const int RUSH2 = 5;
        private const int RUSH3 = 7;
        private const int RUSH_THRESHOLD = 2000;



        public DeskQuote(string customerName, DateTime quoteDate, int width, int depth, int drawers, DesktopMaterial material, int rushDays)
        {
            CustomerName = customerName;
            QuoteDate = quoteDate;
            Desk.Width = width;
            Desk.Depth = depth;
            Desk.NumberOfDrawers = drawers;
            Desk.DesktopMaterial = material;
            RushDays = rushDays;

            SurfaceArea = Desk.Width * Desk.Depth;
        }

        public int CalculateQuoteTotal()
        {
            QuoteAmount = PRICE_BASE + SurfaceAreaCost() + DrawerCost() + (int)Desk.DesktopMaterial + RushOrderCost();
            return QuoteAmount;
        }

        private int SurfaceAreaCost()
        {
            if (SurfaceArea > SIZE_THRESHOLD)
            {
                return (SurfaceArea - SIZE_THRESHOLD) * PRICE_PER_SURFACEAREA; ;

            }
            return 0;
        }
        public int DrawerCost()
        {
            return Desk.NumberOfDrawers* PRICE_PER_DRAWER;
        }
        public int RushOrderCost()
        {
            int rushCost = 0;
            if (RushDays != 0{

            })
        }
        
       

    }

}
