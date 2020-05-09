using System;
using System.Collections.Generic;
using LibExample;

namespace _019_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример создания словаря.
            var dict = new Dictionary<int, Man>
            {
                [3] = Man.GetMan(),
                [4] = Man.GetMan(),
                [1] = Man.GetMan(),
                [2] = Man.GetMan(),
                [5] = Man.GetMan(),
                [6] = Man.GetMan(),
                [7] = Man.GetMan()
            };

            // Пример получения значения по ключу.
            Man str = dict[3];

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
