using System;
using System.Threading;

namespace _3_while
{
    class Program
    {
        static void Main(string[] args)
        {
            uint leftToServeInTheArmy = 365;

            while (leftToServeInTheArmy != 0)
            {
                if (leftToServeInTheArmy <= 91)
                {
                    Console.WriteLine(leftToServeInTheArmy + " Дед");
                }

                if (leftToServeInTheArmy > 91 && leftToServeInTheArmy <= 182 )
                {
                    Console.WriteLine(leftToServeInTheArmy + " Черпак");
                }

                if (leftToServeInTheArmy > 182 && leftToServeInTheArmy < 271)
                {
                    Console.WriteLine(leftToServeInTheArmy + " Слон");
                }

                if (leftToServeInTheArmy >= 271)
                {
                    Console.WriteLine(leftToServeInTheArmy + " Дух");
                }

                leftToServeInTheArmy--;
                // Задержка в одну 0.1 секунду.
                Thread.Sleep(100);
            }

            Console.Clear();
            Console.WriteLine("Дембель!!!");
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
