using System;

namespace lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray; // целоцисленный одномерный массив. 
            string[] stringArray;  // строковой одномерный массив.
            Man[] customClassArray; // Массив кастомных элемнтов.

            // Выделение памяти под 100 элементов.
            intArray = new int[100]; 
            // Переменная для счетчика.
            int iterator = 0;
            // Переменная для спользования генератора случайных чисел.
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

            stringArray = new string[100];
            for (int i = 0; i < stringArray.Length; i++)
                stringArray[i] = string.Format("Element № - {0}", i);

            for (int i = 0; i < stringArray.Length; i++)
                Console.WriteLine(stringArray[i]);

            Console.ReadLine();

            customClassArray = new Man[100];
            for (int i = 0; i < customClassArray.Length; i++)
            {
                customClassArray[i] = new Man();
                customClassArray[i].Age = 33;
                customClassArray[i].FirstName = "Вася";
                customClassArray[i].SecondName = "Иванов";               
            }

            foreach (var element in customClassArray)
            {
                Console.WriteLine(element.ManInfo());
            }

            Console.ReadLine();
        }
    }
}
