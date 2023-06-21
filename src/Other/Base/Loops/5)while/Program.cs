using System;
using System.Threading;

namespace _5_while
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            uint leftToServeInTheArmy = 365 + 1;

            while (leftToServeInTheArmy != 0)
            {
                // Задержка в одну 0.1 секунду.
                Thread.Sleep(100);
                leftToServeInTheArmy--;

                if (leftToServeInTheArmy == 265)
                {
                    Console.WriteLine("Чел помер.");
                    // break - прерывет цикл.
                    break;
                }

                if (leftToServeInTheArmy >= 271)
                {
                    Console.WriteLine(leftToServeInTheArmy + " Дух");
                    continue;
                }

                if (leftToServeInTheArmy > 182 && leftToServeInTheArmy <= 271)
                {
                    Console.WriteLine(leftToServeInTheArmy + " Слон");
                    continue;
                }

                if (leftToServeInTheArmy > 91 && leftToServeInTheArmy <= 182)
                {
                    Console.WriteLine(leftToServeInTheArmy + " Черпак");
                    continue;
                }

                if (leftToServeInTheArmy > 91) Console.WriteLine(leftToServeInTheArmy + " Дед");
            }

            Console.WriteLine("Дембель!!!");
            Console.ReadLine();
        }
    }
}