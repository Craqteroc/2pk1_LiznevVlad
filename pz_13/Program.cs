using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person() { Name = "vlad" };
            Person person2 = new Person() { Name = "vlad" };
            Person person3 = new Person() { Name = "Vlad" };
            Console.WriteLine(person1.Equals(person2));
            Console.WriteLine(person1.Equals(person3));
            Console.ReadKey();
           

        }
        class Person
        {
            public string Name { get; set; }

            public override bool Equals(object obj)
            {
                if (obj.GetType() != this.GetType()) return false;
                Person person = (Person) obj;
                return this.Name == person.Name;
            }
        }
    }
}

