﻿using System;
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
            List<int> list = new List<int> { 1, 4, 5, 9 };
            CustomBuiltList<int> one = new CustomBuiltList<int>() {1, 3, 5 };
            CustomBuiltList<int> two = new CustomBuiltList<int>() { 2, 4, 6 };
            CustomBuiltList<int> three = new CustomBuiltList<int>() { 2, 1, 6 };
            //CustomBuiltList<int> zipList = new CustomBuiltList<int>() { 1, 3, 5 };
            //zipList.Zip(one, two);
            //T[] zipList1 = new T[];
            //T[] zipList2 = new CustomList<int>() { 2, 4, 6 };
            //zipList1.Zip(zipList1, zipList2);
            //CustomList<string> myRemoveList = new CustomList<string>() { "hello", "world", "code" };
            //myRemoveList.Remove("world");
            //CustomList<int> resultOne = new CustomList<int>();
            CustomBuiltList<int> resultTwo = new CustomBuiltList<int>();
            //resultOne = one + two;
            resultTwo = one - three;
            Console.WriteLine(resultTwo);
            Console.ReadLine();

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
            

        }
    }
}
