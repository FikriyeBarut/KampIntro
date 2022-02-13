using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category> {
            new Category { CategoryId = 1, CategoryName = "Bilgisayar" },
            new Category { CategoryId = 2, CategoryName = "telefon" },
            };
            List<Product> products = new List<Product> {
            new Product { ProductId = 1,CategoryId = 1,ProductName="acer laptop",QuantityPerUnit="32 gb ram",UnitPrice=3200,UnitsInStock=5},
            new Product { ProductId = 2, CategoryId = 1, ProductName = "hp laptop", QuantityPerUnit = "16 gb ram", UnitPrice = 7700, UnitsInStock = 5 },
            new Product { ProductId = 3, CategoryId = 1, ProductName = "asus laptop", QuantityPerUnit = "8 gb ram", UnitPrice = 8200, UnitsInStock = 7 },
            new Product { ProductId = 4, CategoryId = 2, ProductName = "samsung telefon", QuantityPerUnit = "4 gb ram", UnitPrice = 10000, UnitsInStock = 8 },
            new Product { ProductId = 5, CategoryId = 2, ProductName = "iphone telefon", QuantityPerUnit = "64 gb ram", UnitPrice = 1500, UnitsInStock = 0 },
            };
            //NewMethod(products);

            // GetAllProducts(products);
            //GetAllProductsLinq(products);

            //AnyTest(products);

            //FindTest(products);
            //FindAllTest(products);

            //AscDescTest(products);

            //ClassicLinqTest(products);

            var result = from p in products
                         join c in categories //productaki her bir p ile kategoride her bir c yi yan yana getir
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice>8000
                         orderby p.UnitPrice descending
                         select new ProductDto
                         {
                             ProductId = p.ProductId,
                             ProductName = p.ProductName,
                             UnitPrice = p.UnitPrice
                         };
            foreach (var productDto in result)
            {
                Console.WriteLine(productDto.ProductName+" "+productDto.CategoryName);

            }

                         }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000
                         orderby p.UnitPrice ascending, p.ProductName ascending
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };//her bir p yi bir tane daha liste yapıp işarete uyaranları o listeye ekliyor
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void AscDescTest(List<Product> products)
        {
            //single line query
            var result = products.Where(p => p.ProductName.Contains("top")).OrderBy(p => p.UnitPrice).ThenByDescending(p => p.ProductName);

            foreach (var product in result)//içinde top olan ürünleri döner
            {
                Console.WriteLine(product.ProductName);

            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));//şaarta uyan tüm elemanlara getirir.liste türünde
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            var a = products.Find(p => p.ProductId == 3);//ürünün detayına gitmek için find kullnabiliriz.
            Console.WriteLine(a);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Acer Laptop");
            Console.WriteLine(result);//true veya false döner
        }

        private static void NewMethod(List<Product> products)
        {
            Console.WriteLine("Algoritmik----------");
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 4)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            Console.WriteLine("Linq-----");
            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 4);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }



        //LINQ YOKSA OLACAKLAR
        static List<Product> GetAllProducts(List<Product> products)
        {
            List<Product> filterProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 4)
                {
                    filterProducts.Add(product);
                }
            }
            return filterProducts;
        }//SON


        //LINQ KULLANIRSAK;
        //elimizde liste varsa filtreleme yaparak kendi listemizi oluşturabiliriz.
        static List<Product> GetAllProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 4).ToList();
        }//SON  
        class ProductDto{
            public int ProductId { get; set; }
            public string CategoryName { get; set; }
            public string ProductName { get; set; }
            public decimal UnitPrice { get; set; }

        }

    }
}
