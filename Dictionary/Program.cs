using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> isimler = new MyDictionary<int, string>();
            isimler.Add(1,"Tahir");
            isimler.Add(2, "Cumali");
            isimler.Add(3, "Sultan");



            Console.WriteLine(isimler.Count);
            
            foreach(var isim in isimler.Values)
            {
                Console.WriteLine(isim);
            }
        }
    }

    class MyDictionary<K, V>
    {
        K[] keys;
        V[] values;
        

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] tempKey = keys;
            V[] tempValue = values;
            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for(int i = 0;i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public int Count
        {
            get { return values.Length; }
        }

        public K[] Keys
        {
            get { return keys; }
        }

        public V[] Values
        {
            get { return values; }
        }
        
    }
}
