using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Scout
    {
        public const string motto = "to obey the Girl Scout law";

        public Scout(int troop, int dues, string name)
        {
           int TroopNumber = troop;
           string FullName = name;
           int MoneyOwed = dues;
        }

        public Scout(string empName, int empTroop, double empOwed)
        {
            name = empName;
            troop = empTroop;
            dues = empOwed;
        }
    
        public Scout() : this(0, 0, "XXX")
         {

         }
        public string name { get; set; }
        public int troop { get; set; }
        public double dues { get; set; }
    }
}
