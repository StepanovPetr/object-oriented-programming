using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Источник данных.
            List<int> scores = new List<int> { 100, 101, 97, 92, 81, 60 };

            // Определите выражение запроса.
            var scoreQuery = scores.Where(s => s > 80).ToList();
            //var scoreQuery =
            //    from score in scores
            //    where score > 80
            //    select score;

            //List<int> scoreQueryToLit = scoreQuery.ToList();

            // выполнение запроса.
            Console.WriteLine("Выполнение до изменения коллекции.");
            foreach (int i in scoreQuery /*scoreQueryToLit*/)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            scores.RemoveRange(0, 2);

            // выполнение запроса.
            Console.WriteLine("Выполнение после изменения коллекции.");
            foreach (int i in scoreQuery /*scoreQueryToLit*/)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
