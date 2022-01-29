using System;
using System.Collections.Generic;
using System.Linq;
using LibExample;

// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/basic-linq-query-operations#filtering
namespace _005_LINQ
{
    class Program
    {
        // Примеры сортировок.
        static void Main(string[] args)
        {
            // Источник данных.
            int[] scores = new int[] { 100, 97, 92, 81, 60, -1, -2, -3, 0 };

            // Определите выражение запроса.
            var scoreQuery =
                from score in scores
                //where (score > 0 && score != 100)
                // сотрировка от меньшего к большему.
                orderby score
                select score;

            // Выполнение запроса.
            Console.WriteLine("Отсортированная коллекция по возрастанию.");
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            // Определите выражение запроса.
            scoreQuery =
                from score in scores
                //where (score > 0 && score != 100)
                // сотрировка от большего к меньшему.
                orderby score descending
                select score;

            // Выполнение запроса.
            Console.WriteLine("Отсортированная коллекция по убыванию.");
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
                //where (person.FirstName != "Петр" && person.Age <= 40)
                orderby person.Age
                select person;

            Console.WriteLine("Отсортированная коллекция по возрастанию.");
            foreach (var i in personQuery)
            {
                Console.WriteLine(i.ManInfo());
            }


            // Определите выражение запроса.
            personQuery =
                from person in persons
                    //where (person.FirstName != "Петр" && person.Age <= 40)
                orderby person.Age descending
                select person;

            Console.WriteLine("Отсортированная коллекция по убыванию.");
            foreach (var i in personQuery)
            {
                Console.WriteLine(i.ManInfo());
            }

            Console.ReadLine();
        }
    }
}
