using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Scout[] scout;
            scout = new Scout [10];
            

            for (int i = 0; i < scout.Length; i++)
            {
                scout[i] = new Scout();
                scout[i].troop = 0;
            }
           
        }
    }
}
