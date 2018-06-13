using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            CustomList<int> myList = new CustomList<int>() { 1, 9, 0 }; 
            CustomList<int> myList1 = new CustomList<int>() { 4, 1, 8 };


            CustomList<int> subList = myList - myList1;



            for (int i = 0; i < subList.Count; i++)
            {
                Console.WriteLine(subList[i]);
            }  */



            /*CustomList<int> testList1 = new CustomList<int>();
            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList1.Add(9);
            testList1.Add(6);
            testList1.Remove(9);

            for (int i = 0; i < testList1.Count; i++)
            {
                Console.WriteLine(testList1[i]);
            }*/

             CustomList<int> myList = new CustomList<int>() {1,2,3,7};

             CustomList<int> myList1 = new CustomList<int>() {4,5,6};

             CustomList<int> resultList = myList.Zip( myList1);

             for (int i = 0; i < resultList.Count; i++)
             {
                 Console.Write(resultList[i] + " ");
             }

            /*

            CustomList<string> myList2 = new CustomList<string>();

            myList2.Add("Hello");
            myList2.Add("World");


            
            //Console.WriteLine(myList2.ToString());
            Console.WriteLine("Iteratoring");
            for (int i = 0; i < myList2.Count; i++)
            {
                Console.WriteLine(myList2[i]);
            } */

            Console.ReadLine();
        }
    }
}
