using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.Mocking
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new VideoService();
            var title = service.ReadVideoTitle();
        }
    }
}
