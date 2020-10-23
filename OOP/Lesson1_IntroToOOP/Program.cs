using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine("Please input Address: ");
            p.Address = Console.ReadLine();

            Console.WriteLine(p.DeLimitAddress(','));
            Console.WriteLine("Press a key to teminate app...");
            Console.ReadKey();

            /*

            p.IdCard = "23363G"; //write

            p.Name = "John";
            p.Surname = "Sultana";

            Console.WriteLine($"{p.FullName}");
            Console.ReadKey();*/
        }
    }
}
