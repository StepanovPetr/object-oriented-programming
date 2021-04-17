using System;
using System.Threading;

namespace _4_while
{
    class Program
    {
        static void Main(string[] args)
        {
            uint leftToServeInTheArmy = 365 + 1;

            while (leftToServeInTheArmy != 0)
            {
                // Задержка в одну 0.1 секунду.
                Thread.Sleep(100);
                leftToServeInTheArmy--;

                if (leftToServeInTheArmy >= 271)
                {
                    Console.WriteLine(leftToServeInTheArmy + " Дух");
                    // continue - прерывет итерацию цикла.
                    continue;
                }

                if (leftToServeInTheArmy > 182 && leftToServeInTheArmy <= 271)
                {
                    Console.WriteLine(leftToServeInTheArmy + " Слон");
                    // continue - прерывет итерацию цикла.
                    continue;
                }

                if (leftToServeInTheArmy > 91 && leftToServeInTheArmy <= 182)
                {
                    Console.WriteLine(leftToServeInTheArmy + " Черпак");
                    // continue - прерывет итерацию цикла.
                    continue;
                }

                if (leftToServeInTheArmy > 91) continue;
                Console.WriteLine(leftToServeInTheArmy + " Дед");
            }

            Console.Clear();
            Console.WriteLine("Дембель!!!");
            Console.ReadLine();
        }
    }
}
