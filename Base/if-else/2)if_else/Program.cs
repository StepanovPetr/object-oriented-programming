using System;

// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else
namespace _2_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            // Обьявление строквоой переменной name;
            string name;
            Console.WriteLine("Enter your name!");
            name = Console.ReadLine();

            // Условный оператор if - србатывает только если переменная name равна (==) Den.
            if (name == "Den")
            {
                // Тело условного оператора.
                Console.WriteLine("Hello Denis!!!");
            }
            else
            {
                // Блок else выполнятеся если name НЕ равна (!=) Den.
                Console.WriteLine("Я вас не завал идите лесом.");
            }

            // Программа выполняется дальше.
            Console.ReadLine();
        }
    }
}