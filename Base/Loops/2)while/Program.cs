using System;
using System.IO;
using System.Threading;

namespace _2_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randInt = rand.Next(1, 101);

            uint yourInt = 0;
            Console.WriteLine("Попробуй угать заданное чило?");

            while (yourInt != randInt)
            {
                Console.WriteLine("Введите число.");

                // Равносильно yourInt = yourInt + 1;
                yourInt++;
                Console.WriteLine(yourInt);

                if (yourInt > randInt)
                {
                    Console.WriteLine("Загаданное число меньше");
                }

                if (yourInt < randInt)
                {
                    Console.WriteLine("Загаданное число больше");
                }

                // Задержка в одну секунду.
                Thread.Sleep(1000);
            }
            Console.WriteLine("Угадал!!!");
            Console.ReadLine();
        }
    }
}
