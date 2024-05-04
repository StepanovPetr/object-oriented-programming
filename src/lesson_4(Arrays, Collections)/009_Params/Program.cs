using System;

namespace _009_Params
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamsExample("First String",
                "Second String",
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.ReadLine();
        }

        private static void ParamsExample(string firstString,
            string secondString, 
            params int[] array)
        {
            Console.WriteLine($"First String - {firstString}");
            Console.WriteLine($"Second String - {secondString}");
            foreach (var item in array)
                Console.WriteLine(item);
        }
    }
}
