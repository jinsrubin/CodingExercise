using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleScanningSystem
{
    public class Terminal
    {

        public Terminal()
        {

        }

        public double ScanProduct(string item)
        {
            double productPrice = 0.00f;
            char[] distinctItem = item.Distinct().ToArray();
            for (int i = 0; i < distinctItem.Length; i++)
            {
                int charFrequency = item.Count(f => (f == distinctItem[i]));
                if (distinctItem[i] == 'A')
                {
                    if (charFrequency >= 3)
                    {
                        productPrice = productPrice + 3.00f;
                        charFrequency = charFrequency - 3;
                    }
                    for (int j = 0; j < charFrequency; j++)
                    {
                        productPrice = productPrice + 1.25;
                    }

                }
                else if (distinctItem[i] == 'C')
                {
                    if (charFrequency >= 6)
                    {
                        productPrice = productPrice + 5.00;
                        charFrequency = charFrequency - 6;
                    }
                    for (int j = 0; j < charFrequency; j++)
                    {
                        productPrice = productPrice + 1.00;
                    }
                }
                else if (distinctItem[i] == 'B')
                {
                    for (int j = 0; j < charFrequency; j++)
                    {
                        productPrice = productPrice + 4.25;
                    }
                }
                else if (distinctItem[i] == 'D')
                {
                    for (int j = 0; j < charFrequency; j++)
                    {
                        productPrice = productPrice + 0.75;
                    }
                }
            }
            return productPrice;
        }
    }
}
