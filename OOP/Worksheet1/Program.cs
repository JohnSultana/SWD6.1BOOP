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
            //Question 1, 4 and 5 
            /*//object instance -> object is when you create a space in memory and you start assigning values to the template you created earlier
            Circle c = new Circle(); //example of an object --> c

            Console.Write("Input a radius: ");
            c.Radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Area is {Math.Round(c.GetArea(), 2)}, Perimiter is {Math.Round(c.GetPerimiter(), 2)}");

            Console.WriteLine("Press a key to teminate...");
            Console.ReadKey();*/

            //----------------------------------------------------------------------

            //Question 2
            /*
            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle();
            Rectangle r3 = new Rectangle();

            Console.Write("Enter length of rectangle 1: ");
            r1.Length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width of rectangle 1: ");
            r1.Width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Enter length of rectangle 2: ");
            r2.Length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width of rectangle 2: ");
            r2.Width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Enter length of rectangle 3: ");
            r3.Length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width of rectangle 3: ");
            r3.Width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"Area of rectangle 1: {r1.GetArea()}, Perimeter of rectangle 1: {r1.GetPerimeter()}");
            Console.WriteLine($"Area of rectangle 2: {r2.GetArea()}, Perimeter of rectangle 2: {r2.GetPerimeter()}");
            Console.WriteLine($"Area of rectangle 3: {r3.GetArea()}, Perimeter of rectangle 3: {r3.GetPerimeter()}");

            Console.WriteLine("");

            Console.WriteLine("Press a key to teminate...");
            Console.ReadKey();*/

            //---------------------------------------------------------------------

            /*
            //Question 5b
            Random rnd = new Random();
            Circle c1 = new Circle();

            for(int i = 1; i < 4; i++)
            {
                double radius = rnd.Next(1, 30);

                c1.Radius = radius;
                Console.WriteLine($"Area of Cirle {i}: {c1.GetArea()}, Perimiter of circle {i}: {c1.GetPerimiter()}");
            }
            Console.ReadKey();*/

            //----------------------------------------------------------------------

            //Question 6
            /*
            Person p1 = new Person();
            Person p2 = new Person();

            p1.Name = "John";
            p2.Name = "James";

            Console.WriteLine($"Person 1 Name: {p1.GetName()}, Person 2 Name: {p2.GetName()}");
            Console.ReadLine();*/

            //----------------------------------------------------------------------

            //Question 7 
            RandomNumbers rNum = new RandomNumbers();
            rNum.GenerateNumbers();
            rNum.FindSum();

            Console.Write("Enter the sum of the two numbers: ");
            rNum.UserNum = Convert.ToInt32(Console.ReadLine());

            if (rNum.IsEqual())
            {
                Console.WriteLine("Well done correct answer!");
            }
            else
            {
                Console.WriteLine("Sorry wrong answer.");
            }
            Console.ReadLine();
        }
    }
}
