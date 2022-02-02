using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class MyDictionary<TKey,TValue>
    {
        TKey[] tkey;
        TValue[] tvalue;

        public MyDictionary()
        {
            tkey = new TKey[0];
            tvalue=new TValue[0];
        }

        public void Add(TKey key, TValue values)

        {
            TKey[] tempArray = tkey;
            tkey = new TKey[tkey.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                tkey[i] = tempArray[i];

            }

            tkey[tkey.Length - 1] = key;

            TValue[] tempArrayy = tvalue;
            tvalue = new TValue[tvalue.Length + 1];
            for (int i = 0; i < tempArrayy.Length; i++)
            {
                tvalue[i] = tempArrayy[i];

            }

            tvalue[tvalue.Length - 1] = values;
        }
            public TValue[] values
        {
            get { return tvalue; }
        }
        public TKey[] key
        {
            get { return tkey; }
        }
    }
    }

