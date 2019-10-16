using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Class
{
    public class Person
    {
        public String Name;

        public void Introbuce(string to)
        {
            Console.WriteLine("Hi {0},I am {1}", to, Name);
        }
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("john");
            person.Introbuce("mosh");
        }
    }
}
