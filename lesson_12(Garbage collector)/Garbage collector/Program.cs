using System;

namespace Garbage_collector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GC.MaxGeneration);

            int val = 10;

            Console.WriteLine(GC.GetGeneration(val));
            Console.ReadLine();
        }
    }
}
