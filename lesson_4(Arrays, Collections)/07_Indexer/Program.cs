using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            IndexerExample indexerExample = new IndexerExample();
            for (int i = 0; i < indexerExample.Count; i++)
            {
                Console.WriteLine(indexerExample[i].ManInfo());
            }
            Console.WriteLine(indexerExample["1"]);
            Console.WriteLine(indexerExample["2"]);
            Console.WriteLine(indexerExample["666"]);
            Console.ReadKey();

        }
    }
}
