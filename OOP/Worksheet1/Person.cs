using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet1
{
    class Person
    {
        public Person(int id)
        {
            Id = id;
        }

        public Person(int id, string name, int age, string locality, string favColor)
        {
            Id = id;
            Name = name;
            Age = age;
            Locality = locality;
            FavColor = favColor;
        }

        int id;
        string name;
        int age;
        string locality;
        string favColor;

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public string Locality { get => locality; set => locality = value; }
        public string FavColor { get => favColor; set => favColor = value; }

        public string GetName()
        {
            return Name;
        }
    }
}
