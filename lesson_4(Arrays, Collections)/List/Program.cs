using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        { 
            // пример List работающего с целочисленными заначениями
            List<int> intList = new List<int>();
            intList.AddRange( new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            foreach (var item in intList)
                Console.WriteLine(item);

            Console.WriteLine();
            // пример List работающего со строками
            List<string> stringList = new List<string>();
            stringList.AddRange(new string[] { "First", "Second", "Third", "Fourth"});

            foreach (var item in stringList)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
