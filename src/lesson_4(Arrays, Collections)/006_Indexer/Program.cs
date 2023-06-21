using System;
using LibExample;

namespace _006_Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Indexer indexer = new Indexer();
            for (var i = 0; i < indexer.Count; i++)
               Console.WriteLine(indexer[i].ManInfo());

            Console.ReadLine();
        }
    }
}
