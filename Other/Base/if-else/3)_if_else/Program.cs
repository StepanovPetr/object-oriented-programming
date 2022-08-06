using System;

namespace _3__if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            // Обьявление строквоой переменной age;
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
                Console.WriteLine("Добро пожаловать в армию!");
            }

            // Условный оператор if Примеры операций сравения.
            if ( age >= 27)
            {
                // Тело условного оператора.
                Console.WriteLine("Слишком стар");
            }

            // Программа выполняется дальше.
            Console.ReadLine();
        }
    }
}
