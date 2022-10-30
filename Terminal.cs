using System.Collections.Generic;
using System.Linq;

namespace PointOfSaleScanningSystem
{
    public class Terminal
    {
        public char ProductCode;
        public int Multiples;
        public decimal Price;
        public Terminal()
        {
        }

        public decimal ScanProduct(string item)
        {
            decimal productPriceTotal = 0.00M;
            var productPricing = SetPricing();
            char[] distinctItem = item.Distinct().ToArray();
            for (int i = 0; i < distinctItem.Length; i++)
            {
                int charFrequency = item.Count(f => (f == distinctItem[i]));
                var list = productPricing.Where(p => p.ProductCode == distinctItem[i]);
                var orderedList = list.OrderByDescending(p => p.Multiples);

                foreach (var element in orderedList)
                {
                    if (charFrequency >= element.Multiples)
                    {
                        int numberOfProductCodes = charFrequency / element.Multiples;
                        productPriceTotal = productPriceTotal + (numberOfProductCodes * element.Price);
                        charFrequency = charFrequency - element.Multiples;
                    }
                }
            }
            return productPriceTotal;
        }

        private List<Terminal> SetPricing()
        {
            List<Terminal> list = new List<Terminal>
            {
                new Terminal{ProductCode='A',Multiples=3,Price=3.00M},
                new Terminal{ProductCode='A',Multiples=1,Price=1.25M},
                new Terminal{ProductCode='B',Multiples=1,Price=4.25M},
                new Terminal{ProductCode='C',Multiples=1,Price=1.00M},
                new Terminal{ProductCode='C',Multiples=6,Price=5.00M},
                new Terminal{ProductCode='D',Multiples=1,Price=0.75M}
            };
            return list;
        }

    }
}
