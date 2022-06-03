using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class MyList<T>
    {

        T[] items;
        T[] tempArray;

        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            tempArray = items;

            items = new T[items.Length + 1];

            for(int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;

        }
    }
}
