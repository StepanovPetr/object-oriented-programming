using System;

namespace _5_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter your age");
            age = int.Parse(Console.ReadLine());

            string isLoshara;
            Console.WriteLine("Enter your Loshara or not?");
            isLoshara = Console.ReadLine();

            // && -- Должны все условия (Лолическое И)
            // || -- Должно выполняться хобы одно условие (Лолическое ИЛИ)

            if (age > 25 || isLoshara == "yes")
            {
                // Тело условного оператора.
                Console.WriteLine("Лови лося !!!");
            }
            else
            {
                Console.WriteLine("Нормальный чел!");
            }

            Console.WriteLine("Hello World!");
        }
    }
}
