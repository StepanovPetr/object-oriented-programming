using System;
using System.Collections.Generic;
using System.Linq;
using LibExample;

// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/basic-linq-query-operations#filtering
namespace _004_LINQ
{
    class Program
    {
        //Примеры фильтрации
        static void Main(string[] args)
        {
            // Источник данных.
            int[] scores = new int[] {100, 97, 92, 81, 60, -1,-2,-3, 0};

            // Определите выражение запроса.
            var scoreQuery =
                from score in scores
                where (score > 0 && score !=100)
                select score;

            // выполнение запроса.
            Console.WriteLine("Отфильтрованная коллекция.");
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            List<Man> persons = new List<Man>() { Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan() };
            foreach (var i in persons)
            {
               Console.WriteLine(i.ManInfo());
            }

            // Определите выражение запроса.
            var personQuery =
                from person in persons
                where (person.FirstName != "Петр" && person.Age <= 40)
                select person;

            Console.WriteLine("Отфильтрованная коллекция.");
            foreach (var i in personQuery)
            {
                Console.WriteLine(i.ManInfo());
            }

            Console.ReadLine();
        }
    }
}
