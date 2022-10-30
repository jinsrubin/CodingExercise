using System;
using System.Globalization;

namespace PointOfSaleScanningSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            var Terminal = new Terminal();
            var productPrice = Terminal.ScanProduct(item);
            Console.WriteLine("$" + productPrice);
            Console.ReadLine();
        }
    }
}
