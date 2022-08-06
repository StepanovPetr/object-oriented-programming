using System;
using System.Collections.Generic;
using QuickSort.Interface;

namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISort sort = new InsertionSort();

            var result =  sort.Sort(new[] { 4, 7, 9, 6, 8, 1, 0, 5, 9});

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            Console.ReadLine();
        }
    }
}
