using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation kümülatif yollandı
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+"Eklendi.");

        }
        public void Guncelle(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
        
    }
}
