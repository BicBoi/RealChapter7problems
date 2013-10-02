using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoScouts
{
    class DemoScouts
    {
        public static void Main()
        {
            GirlScout Slow = new GirlScout();
            Slow.Name = "Slow";
            Slow.Troop = 20;
            Slow.Owed = 99999999999999;

            GirlScout Eugene = new GirlScout("Eugene", 20, 0);

            Console.WriteLine("Name: {0} Troop #: {1} Money owed: ${2}", Slow.Name, Slow.Troop, Slow.Owed);
            Console.WriteLine("Name: {0} Troop #: {1} Money owed: ${2}", Eugene.Name, Eugene.Troop, Eugene.Owed);
            Console.WriteLine(GirlScout.motto);
        }
    }
}