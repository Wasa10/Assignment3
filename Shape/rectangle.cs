using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class rectangle : Ishape
    {
        public double length { get; set; }
        public double width { get; set; }

        public double Area()
        {
            return length * width;
        }

        public double perimeter()
        {
            return 2 * (length + width);
        }
    }
}
