using System;
using System.Globalization;

namespace PointOfSaleScanningSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            Terminal objTerminal = new Terminal();
            var productPrice = objTerminal.ScanProduct(item);
            Console.WriteLine("$" + productPrice);
            Console.ReadLine();
        }
    }
}
