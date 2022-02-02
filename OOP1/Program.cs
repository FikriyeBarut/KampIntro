using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnitPrice = 3;


            //farklı tanımlama şekli
            Product product2 = new Product { Id = 2, CategoryId = 5,UnitPrice=5,ProductName="kalem",UnitsInStock=35 };

            //CamelCase 
            //pascalCase
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

        }
    }
}
