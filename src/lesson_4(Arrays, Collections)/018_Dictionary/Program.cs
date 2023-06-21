using System;
using System.Collections.Generic;

namespace _018_Dictionary
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Пример создания словаря.
            var dict = new Dictionary<int, string>
            {
                [3] = "Windows 95",
                [4] = "Windows 98",
                [1] = "Windows ME",
                [2] = "Windows XP",
                [5] = "Windows 7",
                [6] = "Windows 8",
                [7] = "Windows 10"
            };

            // Пример получения значения по ключу.
            var str = dict[3];

            // Пример обхода словаря в цикле.
            foreach (var i in dict)
                Console.WriteLine($"{i.Key} = {i.Value}");

            Console.WriteLine(new string('-', 120));

            foreach (var value in dict.Values)
                Console.WriteLine(value);

            Console.ReadKey();
        }
    }
}