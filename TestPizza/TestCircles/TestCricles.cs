using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCircles
{
    class Circle
    {
        private double radius;

        public Circle()
        {
            radius = 1;
        }
        public double Radius
        {
            get
            {
                return radius;
          }
            set
          { 
                radius = value;
            }
        }

        public double Area
        {
            get
            {
                return Math.PI * radius * radius;
            }

        }

        public double Diameter
        {
            get
            {
              return 2 * radius;
            }

        }

    }
}
