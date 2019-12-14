using System;

//https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/indexers/+
namespace lesson_4
{    
    class Program
    {
        static void Main(string[] args)

        {
            IndexerExample indexerExample = new IndexerExample();
            //indexerExample._man[1].Age;

            for (int i = 0; i < indexerExample.Count; i++)
            {
                Console.WriteLine(indexerExample[i]);
            }
            Console.ReadKey();
        }
    }
}
