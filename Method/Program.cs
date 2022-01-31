using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//methodlar tekrar tekrar kullanılabilirliği sağlar
//do not repeat yourself
//clean code-best practice yani doğru uygulama teknikleri
namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 23;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)//Urun(var da olur) veri türü class
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
            }
            Console.WriteLine("----------Methodlar--------");

            //instance-ornek bir class oluşturma
            //encapsulation
            /*ayrı ayrı yazacak özellikleri sen bir kapsül içine yazıyorsun
             düzene sokuyorsun*/
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yesil armut", 12,5);
            sepetManager.Ekle2("cilek", "yesil cilek", 15,6);
        }
    }
}
