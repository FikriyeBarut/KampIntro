using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class DortIslem
    {
        public void Topla(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam Sonuc: " + toplam);
        }
        public void Cikar(int sayi1, int sayi2)
        {
            int cikar = sayi1 - sayi2;
            Console.WriteLine("Cikarma Sonuc: " + cikar);
        }
        public void Carp(int sayi1, int sayi2)
        {
            int carp = sayi1 * sayi2;
            Console.WriteLine("Carpma Sonuc: " + carp);
        }
        public void Bol(int sayi1, int sayi2)
        {
            int bol = sayi1 / sayi2;
            Console.WriteLine("Bolme Sonuc: " + bol);
        }
    }
}
