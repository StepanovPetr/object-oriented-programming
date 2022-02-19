using System;
using System.Collections.Generic;
using System.Linq;

namespace _003_LINQ
{
    class Program
    {
        // Пример сохранения результата LINQ запроса.
        static void Main(string[] args)
        {
            // Источник данных.
            List<int> scores = new List<int> { 100, 101, 97, 92, 81, 60 };

            // Определите выражение запроса.
            var scoreQuery =
                from score in scores
                where score > 80
                select score;

            List<int> scoreQueryToLit = scoreQuery.ToList();

            // Выполнение запроса.
            Console.WriteLine("Выполнение до изменения коллекции.");
            foreach (int i in scoreQueryToLit)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            scores.RemoveRange(0, 2);

            // Выполнение запроса.
            Console.WriteLine("Выполнение после изменения коллекции.");
            foreach (int i in scoreQueryToLit)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
