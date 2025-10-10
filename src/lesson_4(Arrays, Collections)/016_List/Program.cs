using System;
using System.Collections;
using System.Collections.Generic;
using LibExample;

namespace _016_List
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Проблема 1.

            var myList = new ArrayList();

            myList.Add(1);
            myList.Add(2);
            //myList.Add("123");

            var sum = 0;
            foreach (var item in myList)
            {
                sum += (int)item;
            }

            // Проблема 2.
            myList = new ArrayList();

            var item1 = new StructExample(true, 111, 111);
            Console.WriteLine(item1.GetHashCode());
            var item2 = new StructExample(false, 222, 222);
            Console.WriteLine(item2.GetHashCode());
            myList.Add(item1);
            myList.Add(item2);

            foreach (var item in myList)
            {
                Console.WriteLine(item.GetHashCode());
            }

            // Пример List работающего с целочисленными значениями.
            var intList = new List<int>();
            intList.AddRange(new[] 
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
            //intList.Add("dfdf");

            foreach (var item in intList)
                Console.WriteLine(item);

            Console.WriteLine();
            // Пример List работающего со строками.
            var stringList = new List<string>();
            stringList.AddRange(new[] 
                {"First", "Second", "Third", "Fourth"});

            Console.WriteLine(stringList.Capacity);
            stringList.Add("Five");
            Console.WriteLine(stringList.Capacity);

            foreach (var item in stringList)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}