using System;

namespace lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            // Пример заполения массива элемантами при создании.
            int[,] intArray = new int[5, 5];                          
                    
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5 ; j++)
                {
                    intArray[i,j] = rand.Next(100, 1001);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0},{1} - {2}  ", i, j, intArray[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            string[,] stringArray = new [,] 
            { {"One","Two","Three"}, 
                { "One", "Two", "Three" }, 
                { "One", "Two", "Three" }};
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0},{1} - {2}  ", i, j, stringArray[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            Man[,] customClassArray = new Man[,] 
                { { Man.GetMan(), Man.GetMan(), Man.GetMan() }, 
                    { Man.GetMan(), Man.GetMan(), Man.GetMan() }, 
                    { Man.GetMan(), Man.GetMan(), Man.GetMan()}};
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("{0},{1} - {2}  ", i, j, customClassArray[i, j].ManInfo());
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
