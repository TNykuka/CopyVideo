using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_AccessModifiers_Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new Ratecalculator();
            var rating = calculator.Calculate();

            Console.WriteLine("Promote logic changed.");
        }
    }
}
