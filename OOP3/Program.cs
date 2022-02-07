using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            //IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();


            IKrediManager tasitKrediManager=new TasitKrediManager();
            //TasitKrediManager tasitKrediManager =new TasitKrediManager();
            
            IKrediManager konutKrediManager = new KonutKrediManager();
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
           

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService loggerService = new FileLoggerService();    


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager,databaseLoggerService);//burda ne gönderirsen o çalıştı



            List<IKrediManager> krediler=new List<IKrediManager>() {ıhtiyacKrediManager,tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            /* interface de o interface i implements eden classın referans numarasını
             * tutabiliyor.
             */


        }
    }
}
