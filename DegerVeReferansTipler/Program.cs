using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*sayisal veri tipleri(int,float,bool,fouble,decimal)deger tiplerdir.
             bellekte stack ve heap diye alanlar var.Deger tiptekiler stackte gerçekleşir.
             değer tiplerde değeri atarsın*/
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1= sayi2;
            sayi2 = 65;
            //sayi1=30

            int[] sayilar1 = new int[] {10,20,30};
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]=999


            /* referans tipler(class,array,interface).referans tiplerde adresi atarsın.
            sayilar1 stackte tanımlandı.New dediğimiz anda heapte bir alan oluştu ve değerler yazıldı.
            İkisinin bağlantısı ise adres alanı ile sağlanıyor.
            (new demek bellekte bir adres oluştur demek)
            sayilar1=sayilar2 demek sayilar1 in referans numarası sayilar2 nin referans numarasına eşit demek.
              */
        }
    }
}
