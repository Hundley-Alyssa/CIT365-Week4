using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_AlyssaHundley
{
    class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }
        public string Material { get; set; }
        public int Rush { get; set; }

        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;


    }
}
