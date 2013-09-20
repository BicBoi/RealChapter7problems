using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HousePlant
{
    class DisplayHousePlant
    {
        public static void Main()
        {
            HousePlant dandelion = new HousePlant();
            dandelion.Name = "dandelion";
            dandelion.Price = 2.00;
            dandelion.Fed = true;


            HousePlant daisy = new HousePlant();
            daisy.Name = "daisy";
            daisy.Price = 1.95;
            daisy.Fed = true;

            HousePlant Philodendron = new HousePlant();
            Philodendron.Name = "Philodendron";
            Philodendron.Price = 3.00;
            Philodendron.Fed = false;

        }
    }
}
