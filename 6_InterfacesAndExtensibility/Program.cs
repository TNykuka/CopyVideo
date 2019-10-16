using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_InterfacesAndExtensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("D:/[OOP] - Object Oriented Programming/1.txt"));
            dbMigrator.Migrate();
        }
    }
}
