using System;

namespace _3_Inherritance
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FonrName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }
    }
}
