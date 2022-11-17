using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methots
{
    public class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + product.productName);
        }

        public void add2(string productName, double price, string aboutProduct, int stokAdedi)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + productName);
        }
    }
}
