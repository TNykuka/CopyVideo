using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            var circle = new Circle();
            circle.Draw();

            var rectangle = new Retangle();
            rectangle.Draw();
        }
    }
}
