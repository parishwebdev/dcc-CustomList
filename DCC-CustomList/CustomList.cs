using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_CustomList
{
    public class CustomList<T>
    {

        T[] genericArray;

        int capacity;
        int count;

        public int Capacity { get; set; }
        public int Count { get; set; }

        public T[] GenericArray { get; set; }

        public CustomList()
        {

            GenericArray = new T[Capacity];
        }

        public void Add(T value)
        {

        }
        public void Remove(T value)
        {

        }

        //Indexer

        //-----------------------------
        //Come to Later
        public void Zip()
        {

        }

        /*
          Overriding + and -
         */

    }
}
