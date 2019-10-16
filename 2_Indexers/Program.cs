using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace _2_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Mosh";
            Console.WriteLine(cookie["name"]);
        }
    }
}
