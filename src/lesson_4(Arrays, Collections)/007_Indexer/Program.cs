using System;
using LibExample;

namespace _007_Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            Console.WriteLine(man[1]);
            Console.WriteLine(man["1"]);

            Console.ReadLine();
        }
    }
}
