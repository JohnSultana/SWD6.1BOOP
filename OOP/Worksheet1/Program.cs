using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet1
{
    class Program
    {
        static void Main(string[] args)
        {
            //object instance -> object is when you create a space in memory and you start assigning values to the template you created earlier
            Circle c = new Circle(); //example of an object --> c

            Console.Write("Input a radius: ");
            c.Radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Area is {Math.Round(c.GetArea(), 2)}, Perimiter is {Math.Round(c.GetPerimiter(), 2)}");

            Console.WriteLine("Press a key to teminate...");
            Console.ReadKey();
        }
    }
}
