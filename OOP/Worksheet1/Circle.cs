using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet1
{
    class Circle
    {
        //constructor bears the same name as the class which is used to create an instance of a class(the object)
        //  secondary objective of a construct: is can be used as a normal method
        public Circle()
        {
            Radius = 0; //setting to default values
            Colour = "Black";
        }

        public string Colour { get; set; }
        public double Radius { get; set; } //property

        public string GetRadius()
        {
            return "Radius: " + Radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetPerimiter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
