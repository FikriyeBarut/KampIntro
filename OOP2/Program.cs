using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Fikriye";
            musteri1.Soyadi = "Barut";
            musteri1.TcNo = "123";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12345";
            musteri2.MusteriNo = "5432";
            musteri2.SirketAdi = "kodlama";
            musteri2.VergiNo = "12334242";


            //gerçek müşteri-tüzel müşteri
            //SOLID


            //musteri classı hem gercek musterinin referansını hem de tuzel musterinin referansını tutabiliyor.
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);

        }
    }
}
