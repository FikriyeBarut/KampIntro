using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği veri türü yazma gerekliliği
            //do not repeat yourself
            String kategoriEtiketi = "Kategori";
            int ogrenciSayi = 320000;
            double faizOrani = 1.45;
            bool sistemeGirisYaptiMi = false;
            Console.WriteLine(kategoriEtiketi);
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarBugun < dolarDun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi");
            }

            if (sistemeGirisYaptiMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
        }
    }
}
