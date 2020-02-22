using System;
using System.Linq;

namespace _016_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            // Источник данных.
            int[] scores = new int[] { 97, 92, 81, 60 };

            // Определите выражение запроса.
            var scoreQuery = scores.Where(s => s > 80);

            // Определите выражение запроса.
            //var scoreQuery =
            //    from score in scores
            //    where score > 80
            //    select score;

            // выполнение запроса.
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
