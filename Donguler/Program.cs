using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array tanımlama
            //tip[] ad =new tip[] {"....",".....","...."};
            String[] dersler = new string[] {"Yazılım Geliştirici Kursu","Java","Programlamaya giriş" };


            for (int i = 0; i <dersler.Length; i++)
            {
                Console.WriteLine(dersler[i]);
            }
            Console.WriteLine("for bitti");
            
            foreach (String kurs in dersler)// kurs burda alias,dizi türünde elemanları tek tek dolaşır
            {
                Console.WriteLine(kurs);    
            }


            Console.WriteLine("Bitti");
        }
    }
}
