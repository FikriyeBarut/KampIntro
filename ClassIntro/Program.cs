using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yas = 36;

            Kurs kurs1=new Kurs(); //tipi kurs
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "engin";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs(); //tipi kurs
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "kerem";
            kurs2.IzlenmeOrani = 67;


            Kurs kurs3 = new Kurs(); //tipi kurs
            kurs3.KursAdi = "java";
            kurs3.Egitmen = "fikriye";
            kurs3.IzlenmeOrani = 78;

            //Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);
            
            //içinde kurs tutabileceğim yani obje tutabileceğim bir dizi
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+":"+kurs.Egitmen);

            }
        }
    }
    class Kurs
    {
        public String KursAdi { get; set; }
        public String Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
