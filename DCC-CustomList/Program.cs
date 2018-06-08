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
           // List<int> lists = new List<int>();
            CustomList<int> myList = new CustomList<int>();

            myList.Add(1); //0
            myList.Add(22); //1
            myList.Add(59); //2
            myList.Add(559); //3
            
            Console.WriteLine( myList.IndexOf(59));

            CustomList<string> myList2 = new CustomList<string>();

            myList2.Add("Hello");
            myList2.Add("World");

            //Console.WriteLine(myList2.ToString());
            Console.WriteLine("Iteratoring");
            for (int i = 0; i < myList2.Count; i++)
            {
                Console.WriteLine(myList2[i]);
            }

            Console.ReadLine();
        }
    }
}
