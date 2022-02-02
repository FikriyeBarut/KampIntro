using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " Adlı Müşterimiz Listeye Adınız Eklenmiştir.");
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " Adlı Müşterimiz Listeden Adınız Silinmiştir.");
        }
        public void Listele(string Ad,string Soyad,int Telefon,string Adres)
        {
                Console.WriteLine("Musterinin Adi : "+Ad + " Soyadı :" +Soyad+ " Telefon :" + Telefon + " Adres : "+Adres);
        }
    }
}
