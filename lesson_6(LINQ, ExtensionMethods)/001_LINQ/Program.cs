using System;
using System.Linq;

// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/
namespace _001_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Источник данных.
            int[] scores = new int[] { 97, 92, 81, 60 };

            // Определите выражение запроса.
            var scoreQuery =
                from score in scores
                where score > 80
                select score;

            // Выполнение запроса.
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
