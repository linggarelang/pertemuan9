using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Latihan
{
    public class Printer
    {
        public string nama { get; set; }
        public virtual void showPrint()
        {
            Console.WriteLine("Printer display dimensions : ...");
            Console.WriteLine("All Printer Printing...");
        }
    }

    public class Epson : Printer
    {
        public override void showPrint()
        {
            Console.WriteLine("Epson display dimensions : 10*11");
            Console.WriteLine("Epson Printer Printing...");
        }

    }
    public class Canon : Printer
    {
        public override void showPrint()
        {
            Console.WriteLine("Canon display dimensions : 9.5*11");
            Console.WriteLine("Canon Printer Printing...");
        }

    }
    public class LaserJet : Printer
    {
        public override void showPrint()
        {
            Console.WriteLine("LaserJet display dimensions : 12*12");
            Console.WriteLine("LaserJet Printer Printing...");
        }

    }
}