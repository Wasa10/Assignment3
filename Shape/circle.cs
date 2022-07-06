using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class circle : Ishape
    {
        private static double PI = 3.14;
        public double radius { get; set; }
        public double Area()
        {
            return PI * (radius*radius);
        }

        public double perimeter()
        {
            return 2*PI *radius;
        }
    }
}
