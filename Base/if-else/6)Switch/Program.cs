using System;

namespace _6_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Army position");
            string position = Console.ReadLine();

            switch (position)
            {
                case "Младщий сержант":
                {
                    Console.WriteLine("Самый крутой чел в армии!");
                    break;
                }
                case "Ефрейтор":
                {
                    Console.WriteLine("Лучше дочь проститутка!");
                    break;
                }
                case "Редовой":
                {
                    Console.WriteLine("Чистые погоны чистая совесть");
                    break;
                }
                case "Генерал":
                {
                    Console.WriteLine("Господь-Бог.");
                    break;
                }
                default:
                {
                    Console.WriteLine("Какой-то чел ");
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
