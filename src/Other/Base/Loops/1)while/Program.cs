using System;

namespace _1_while
{
    class Program
    {
        static void Main(string[] args)
        {
            // new - выделение памяти перевод. новый.
            Random rand = new Random();
            // Случайное значение от 1 до 100.
            int randInt = rand.Next(1, 101);

            uint yourInt = 0;
            Console.WriteLine("Попробуй угать заданное чило?");

            // != не равно.
            // while -- перевод. пока.
            while (yourInt != randInt)
            {
                Console.WriteLine("Введите число.");
                yourInt = uint.Parse(Console.ReadLine());

                if (yourInt > randInt)
                {
                    Console.WriteLine("Загаданное число меньше");
                }

                if (yourInt < randInt)
                {
                    Console.WriteLine("Загаданное число больше");
                }
            }

            Console.WriteLine("Угадал!!!");
            Console.Beep(698, 500);
            Console.Beep(659, 500);
            Console.Beep(587, 500);
            Console.Beep(523, 500);
            Console.Beep(784, 500);
            Console.Beep(784, 500);
            Console.Beep(698, 500);
            Console.Beep(587, 500);
            Console.Beep(523, 500);
            Console.Beep(784, 500);
            Console.Beep(784, 500);
            Console.ReadLine();
        }
    }
}
