using System;
using Microsoft.VisualBasic;

namespace _4_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter your age");
            age = int.Parse(Console.ReadLine());

            // Условный оператор if Примеры операций сравения.
            if (age < 18)
            {
                // Тело условного оператора.
                Console.WriteLine("Еше молод для армии!");
            }

            // Условный оператор if Примеры операций сравения && (логическое И) - обьединяет несколько условий.
            if (age >= 18 && age < 27)
            {
                // Тело условного оператора.
                if (age >= 18 && age < 25)
                {
                    Console.WriteLine("Все ништяк");
                }

                if (age >= 25 && age < 27)
                {
                    Console.WriteLine("Что ты тут забыл?");
                }
            }

            // Условный оператор if Примеры операций сравения.
            if (age >= 27)
            {
                // Тело условного оператора.
                Console.WriteLine("Слишком стар");
            }

            // Программа выполняется дальше.
            Console.ReadLine();
        }
    }
}
