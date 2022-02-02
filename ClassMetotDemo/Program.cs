using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 =new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Filiz";
            musteri1.Soyad = "Aci";
            musteri1.Telefon = 1234;
            musteri1.Adres = "Beyoğlu";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Ahmet";
            musteri2.Soyad = "Bal";
            musteri2.Telefon = 2345;
            musteri2.Adres = "Avcilar";

            MusteriManager musteriManager=new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);

            musteriManager.Listele(musteri1.Ad,musteri1.Soyad,musteri1.Telefon,musteri1.Adres);
            musteriManager.Listele(musteri2.Ad, musteri2.Soyad, musteri2.Telefon, musteri2.Adres);



        }
    }
}
