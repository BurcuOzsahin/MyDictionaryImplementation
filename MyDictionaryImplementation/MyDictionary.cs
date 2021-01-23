using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryImplementation
{
    class MyDictionary<K,V>
    {
        K[] key;
        V[] value;
        K[] tempKey;
        V[] tempValue;
        public MyDictionary()
        {
            key = new K[0];
            value = new V[0];
        }
        public void Add(K candidateKey, V candidateValue)
        {
            
            tempKey = key;
            tempValue = value;

            key = new K[key.Length + 1];
            value = new V[value.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                key[i] = tempKey[i];

            }
            for (int i = 0; i < tempValue.Length; i++)
            {

                value[i] = tempValue[i];
            }

            key[key.Length - 1] = candidateKey;
            value[value.Length - 1] = candidateValue;



        }
       

        public int Count { get { return key.Length; } }
        public K[] Keys { get { return key; } }
        public V[] Values { get { return value; } }
    }
    }

