using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Standart diziler sabit boyutludur programlama aşamasında dizinin boyutu belirtilir ve programın çalışması sırasında değiştirilemez.
              Dictionary ise değişken boyutludur.
              Eleman ekleme ve çıkarma durumuna göre boyutu dinamik olarak değişmektedir.
              Dictionary koleksiyonunda  Anahtar(Key) ve Değer(Value) olmak üzere iki kavram vardır.
              İstenilen value değerine ulaşmak için key'i kullanırız.
             */
            MyDictionary<int,string> dictionary = new MyDictionary<int,string>();
            dictionary.Add(1,"ali");
            dictionary.Add(2, "ahmet");
            dictionary.Add(3, "veli");
            dictionary.Add(4, "selin");

            foreach (var bilgi in dictionary.values)
            {
                Console.WriteLine("Value değerleri: "+bilgi);
            }
            foreach (var bilgi in dictionary.key)
            {
                Console.WriteLine("Key değerleri: "+bilgi);
            }
        }
    }
}
