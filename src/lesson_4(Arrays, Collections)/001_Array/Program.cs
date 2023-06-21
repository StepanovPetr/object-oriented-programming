using System;
using LibExample;

namespace _001_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Целочисленный одномерный массив. 
            int[] intArray;
            // Строковой одномерный массив.
            string[] stringArray;
            // Массив пользовательских классов.
            Man[] customClassArray; 

            // Выделение памяти под 100 элементов.
            intArray = new int[100];
            // Переменная для счетчика.
            int iterator = 0;
            // Переменная для использования генератора случайных чисел.
            Random rand = new Random();
            while (iterator < intArray.Length)
            {
                // Получение случайного значения и добавление его в массив.
                intArray[iterator] = rand.Next(0, 101);
                iterator++;
            }
            iterator = 0;
            while (iterator < intArray.Length)
            {
                // Вывод текущего элемента на экран.
                Console.WriteLine(" {0} -- {1}", iterator, intArray[iterator]);
                iterator++;
            }
            Console.ReadLine();

            // Выделение памяти под 100 элементов.
            stringArray = new string[100];
            for (int i = 0; i < stringArray.Length; i++)
                stringArray[i] = $"Element № - {i}";

            for (int i = 0; i < stringArray.Length; i++)
                Console.WriteLine(stringArray[i]);

            Console.ReadLine();

            // Выделение памяти под 100 элементов.
            customClassArray = new Man[100];
            for (int i = 0; i < customClassArray.Length; i++)
            {
                customClassArray[i] = new Man
                {
                    Age = 33,
                    FirstName = "Вася",
                    SecondName = "Иванов"
                };
            }

            foreach (var element in customClassArray)
            {
                // Вывод текущего элемента на экран.
                Console.WriteLine(element.ManInfo());
            }

            Console.ReadLine();
        }
    }
}
