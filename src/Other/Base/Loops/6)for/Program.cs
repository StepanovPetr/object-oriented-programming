using System;

namespace _6_for
{
    class Program
    {
        static void Main(string[] args)
        {
            // new - выделение памяти перевод. новый.
            Random rand = new Random();
            // Случайное значение от 1 до 100.
            int randInt = rand.Next(1, 101);

            Console.WriteLine("Попробуй угать заданное чило?");

            // for -- перевод. для.
            // uint yourInt = 0 -- отрабатывает один раз в самом начале цикла.
            for (uint yourInt = 0; yourInt != randInt; yourInt = uint.Parse(Console.ReadLine())) 
            {
                Console.WriteLine("Введите число.");
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
