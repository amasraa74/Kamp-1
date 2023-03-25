﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;
        public MyDictionary()
        {
            keys= new K[0];
            values= new V[0];
        }

        public void Add(K key, V value) 
        {
            K[] tempKey = keys;
            keys = new K[keys.Length + 1];
            V[] tempValue = values;
            values =new V[values.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
            }
            keys[keys.Length - 1] = key;
            for (int i = 0; i < tempValue.Length; i++)
            {
                values[i] = tempValue[i];
            }
            values[values.Length - 1] = value;
            Console.WriteLine(keys.Length + " " + values.Length);
        }


    }
}
