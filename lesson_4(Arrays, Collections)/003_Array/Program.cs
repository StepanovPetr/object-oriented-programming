using System;
using LibExample;

namespace _003_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            // Пример заполения массива элемантами при создании.
            int[] intArray = new int[] { rand.Next(1, 11) * 10, 
                rand.Next(1, 11) * 10, rand.Next(1, 11) * 10, 
                rand.Next(1, 11) * 10, rand.Next(1, 11) * 10,
                rand.Next(1, 11) * 10, rand.Next(1, 11) * 10, 
                rand.Next(1, 11) * 10, rand.Next(1, 11) * 10, 
                rand.Next(1, 11) * 10 }; 
            string[] stringArray = new string[] { "SomeStrgin", 
                "SomeStrgin", "SomeStrgin", "SomeStrgin", "SomeStrign" };
            Man[] customClassArray = new [] { Man.GetMan(), 
                Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), 
                Man.GetMan(), Man.GetMan(), Man.GetMan() };

            // Переменная для счетчика.
            int iterator = 0;

            while (iterator < intArray.Length)
            {
                // Вывод текущего элемента на экран.
                Console.WriteLine(" {0} -- {1}", iterator, intArray[iterator]);
                iterator++;
            }
            Console.ReadLine();


            for (int i = 0; i < stringArray.Length; i++)
                // Вывод текущего элемента на экран.
                Console.WriteLine(stringArray[i]);

            Console.ReadLine();

            foreach (var element in customClassArray)
            {
                // Вывод текущего элемента на экран.
                Console.WriteLine(element.ManInfo());
            }

            Console.ReadLine();
        }
    }
}
