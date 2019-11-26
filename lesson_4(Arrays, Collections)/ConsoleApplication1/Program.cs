using System;

namespace lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Пример заполения массива элемантами при создании 
            int[] intArray = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }; // целоцисленный одномерный массив. 
            string[] stringArray = new string[5] { "SomeStrgin", "SomeStrgin", "SomeStrgin", "SomeStrgin", "SomeStrign"}; 
            Man[] customClassArray = new Man[4] {new Man(), new Man(), new Man(), new Man() { Age= 44, FirstName= "Владимир", SecondName="Цыганок"}}; // Массив кастомных элемнтов.
          
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
                Console.WriteLine(stringArray[i]);

            Console.ReadLine();           

            foreach (var element in customClassArray)
            {
                Console.WriteLine(element.ManInfo());
            }

            Console.ReadLine();
        }
    }
}
