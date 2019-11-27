﻿using System;
using System.Collections;

namespace _10_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new ArrayList();
           
            string s = "Hello";
            myList.Add(s);
            myList.Add("Word");
            myList.Add(666);
            myList.Add(new object());

            foreach (var item in myList)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
