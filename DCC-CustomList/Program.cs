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
            myList.Add(5); //4
            myList.Add(9); //5
            myList.Add(46); //6
            myList.Add(16); //7
            myList.Add(14); //8
            myList.Add(25); //9
            myList.Add(35); //10
            myList.Add(555); //11
            myList.Add(101); //12


            Console.WriteLine(myList[3]);

            Console.ReadLine();
        }
    }
}
