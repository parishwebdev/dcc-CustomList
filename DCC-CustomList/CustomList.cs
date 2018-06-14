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
        
        public T this[int i]
        {
            get { return GenericArray[i]; }
            set { GenericArray[i] = value; }
        }
        
       public  CustomList<T> Zip( CustomList<T> c2)
        {
           CustomList<T> resultList = new CustomList<T>();
           for (int i = 0; i < this.Count || i < c2.Count; i++)
            {
               if (CheckCountForZip(this,i))
                {
                    resultList.Add(c2[i]);
                }
                else if (CheckCountForZip(c2, i))
                {
                    resultList.Add(this[i]);
                }
                else
                {
                    resultList.Add(this[i]);
                    resultList.Add(c2[i]);
                }
            }
            return resultList;
        }

        private bool CheckCountForZip(CustomList<T> listToCheck, int count)
        {
            if (listToCheck.Count <= count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < GenericArray.Length; i++)
            {
                yield return GenericArray[i];
            }
        }
        
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
            for (int i = 0; i < c1.Count && i < c2.Count; i++)
            {
                if (c1.Contains(c2[i]))
                {

                    list.Remove(c2[i]);
                } 
            }
            return list;
        }

        /*
          GnomeSort:
          Why I choose it was it sounded cool. Also, how the way it used indexs I though was nice.
        */
        public static CustomList<int> IntSort(CustomList<int> listToSort) 
        {
            int idx = 0;
            int c = listToSort.Count;

            while (idx < c)
            {
                if (idx == 0)
                    idx++;
                if (listToSort[idx] >= listToSort[idx - 1])
                    idx++;
                else
                {
                    int temp = 0;
                    temp = listToSort[idx];
                    listToSort[idx] = listToSort[idx - 1];
                    listToSort[idx - 1] = temp;
                    idx--;
                }
            }

            return listToSort;
        }

    }
}
