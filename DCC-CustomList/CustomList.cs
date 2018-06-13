using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_CustomList
{
    public class CustomList<T> : IEnumerable
    {
        T[] genericArray;

        int capacity;
        int count;

        public int Capacity { get { return capacity; } set { capacity = value; } }
        public int Count {
            get { return count; }
            set { count = value; }
        }

        public T[] GenericArray { get { return genericArray;} set { genericArray = value; } }

        public CustomList()
        {
            Count = 0;
            Capacity = 5;
            GenericArray = new T[Capacity];
        }



        public bool Contains(T value)
        {
            for (int i = 0; i < GenericArray.Length; i++)
            {
                if (value.Equals(GenericArray[i]))
                {
                    return true;
                }
            }
            return false;
        }
        
        public int IndexOf(T value) 
        {
            int index = 0;
            for (int i = 0; i < GenericArray.Length; i++)
            {
                if (GenericArray[i].Equals(value))
                {
                    index = i;
                    break;
                }
                else
                {
                    index = -1;
                }
            }
            return index;
        }

        public void Add(T value) 
        {

            if (this[0] == null)
            {
                this[0] = value;
            }
            else
            {
              this[Count] = value;
            }

            CheckCount();
            Count++;
            
        }
        public void CheckCount()
        {
            if (Count > Capacity - 3)
            {
                AddRangeToArray(GenericArray, 5);
            }
        }

        public void AddRangeToArray(T[] arrayToExand, int amountToAdd)
        {
            Capacity += amountToAdd;
            T[] tempArray = new T[Capacity];

            for (int i = 0; i < arrayToExand.Length; i++)
            {
                tempArray[i] = arrayToExand[i];
            }

            GenericArray = tempArray;

        }


        public void Remove(T value)
        {
            if(this.IndexOf(value) == -1)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                T[] tempArray = new T[Capacity];
                for (int i = 0; i < GenericArray.Length; i++)
                {
                    if (this.IndexOf(value) == i)
                    {
                        Count--;
                        continue;
                    }
                    else
                    {
                        if (this.IndexOf(value) < i)
                        {
                            tempArray[i - 1] = GenericArray[i];
                        }
                        else
                        {
                            tempArray[i] = GenericArray[i];
                        }
                    }
                }
                GenericArray = tempArray;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Count; i++)
            {
                sb.Append(GenericArray[i] + " ");
            }
            return sb.ToString();
        }

        //Indexer
        public T this[int i]
        {
            get { return GenericArray[i]; }
            set { GenericArray[i] = value; }
        }

        //-----------------------------
        //Come to Later
        
       public void Zip()
        {

        }
        /*
        private Enumerable<T> ZipIteratior(T[] tFirst, T tSecond, T tResult)
        {
            IEnumerable e1 = 
        }*/
        

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < GenericArray.Length; i++)
            {
                yield return GenericArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        /*
          Overriding + and -
         */
        public static CustomList<T> operator+(CustomList<T> c1, CustomList<T> c2) 
        {
            CustomList<T> list = new CustomList<T>();

            for (int i = 0; i < c1.Count; i++)
            {
                list.Add(c1[i]);
            }
            for (int i = 0; i < c2.Count; i++)
            {
                list.Add(c2[i]);
            }
            return list;
        }
        public static CustomList<T> operator-(CustomList<T> c1, CustomList<T> c2)
        {
            CustomList<T> list = c1;
            for (int i = 0; i < c2.Count; i++)
            {
                if (c1.Contains(c2[i]))
                {

                    list.Remove(c2[i]);
                } 
            }
            return list;
        }
            


      
        
        
    }
}
