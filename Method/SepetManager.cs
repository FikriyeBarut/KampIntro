using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class SepetManager//manager-controller vs. gibi şeyler bir operasyon tutuyo demek
    {
        //method yazımı
        public void Ekle(Urun urun)//parantez ise method
        {
            Console.WriteLine("Tebrikler.!Sepete eklendi::"+urun.Adi);

        }
        public void Ekle2(String urunAdi,string aciklama,double fiyat,int StockAdedi)
        {
            Console.WriteLine("Tebrikler.!Sepete eklendi:" +urunAdi);
        }
    }
}
