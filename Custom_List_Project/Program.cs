using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomList<int> myList = new CustomList<int>() { 3, 4 };
            List<int> numbers = new List<int>() { 2, 5, 6, 2, 9, 4, 22, 3, 6, 10 };
            numbers.Remove(2);
            numbers.Remove(3);
            //CustomList<int> customList = new CustomList<int>();
            //customList.Add(2);
            //customList.Add(7);
            //customList.Add(10);
            //customList.Add(22);
            //customList.Add(4);
            //BuiltInListMethod builtIn = new BuiltInListMethod();
            //builtIn.RunList();
            //List<int> list = new List<int>();
            //list.Add(2);
            //list.Add(4);
            //list.Add(6);
            //list.Add(24);
            //list.Add(13);
            //List<string> list2 = new List<string>();
            //list2.Add("one");
            //list2.Add("seven");
            //list2.Add("four");
            //CustomList<int> customList = new CustomList<int>();
         
        }
    }
}
