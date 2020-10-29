using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet1
{
    class Rectangle
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public double Length { get; set; }
        public double Width { get; set; }

        public double GetArea()
        {
            return Length * Width;
        }

        public double GetPerimeter()
        {
            return 2 * (Length + Width);
        }
    }
}
