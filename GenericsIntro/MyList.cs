using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        //classı new lediğimiz anda çalışan blok constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;//gecici dizinin referansı =items ın referansı .gecici olarak items ın elemanlarını tutuyo
            items=new T[items.Length+1];//dizinin eleman sayısını 1 arttırır
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];//items eski değerlerine kavuştu
            }

            items[items.Length - 1] = item;//eklenmek istenen eleman sona eklendi




        }
    }
}
