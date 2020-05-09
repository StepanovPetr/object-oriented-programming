using System;
using System.Collections.Generic;

namespace _016_List
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Пример List работающего с целочисленными значениями.
            var intList = new List<int>();
            intList.AddRange(new[] 
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10});

            foreach (var item in intList)
                Console.WriteLine(item);

            Console.WriteLine();
            // Пример List работающего со строками.
            var stringList = new List<string>();
            stringList.AddRange(new[] 
                {"First", "Second", "Third", "Fourth"});

            foreach (var item in stringList)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}