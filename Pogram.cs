using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Latihan
{
    public class Pogram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilih Printer : ");
            Console.WriteLine("1. Printer Epson ");
            Console.WriteLine("2. Printer Canon ");
            Console.WriteLine("3. Printer LaserJet ");
            Console.Write("Pilih Nomor Printer : [1...3]");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Printer epson = new Epson();
                    epson.showPrint();
                    break;
                case 2:
                    Printer canon = new Canon();
                    canon.showPrint();
                    break;
                case 3:
                    Printer laserJet = new LaserJet();
                    laserJet.showPrint();
                    break;
                default:
                    Printer printer = new Printer();
                    printer.showPrint();
                    break;
            }
        }
    }
}