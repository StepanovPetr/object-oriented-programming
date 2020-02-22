using System;
using System.Collections.Generic;
using System.Linq;

namespace _020_LINQ
{
    class Program
    {
        //Примеры сортировок
        static void Main(string[] args)
        {
            // Источник данных.
            int[] scores = new int[] { 100, 97, 92, 81, 60, -1, -2, -3, 0 };

            // Определите выражение запроса.
            var scoreQuery = scores.OrderBy(s => s);

                //from score in scores
                //orderby score
                //select score;

            // выполнение запроса.
            Console.WriteLine("Отсортированная коллекция по возрастанию.");
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Определите выражение запроса.
            scoreQuery = scores.OrderByDescending(s => s);

            //from score in scores
            //orderby score descending
            //select score;

            // выполнение запроса.
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
            var personQuery = persons.OrderBy(p => p.Age);
                //from person in persons
                //orderby person.Age
                //select person;

            Console.WriteLine("Отсортированная коллекция по возрастанию.");
            foreach (var i in personQuery)
            {
                Console.WriteLine(i.ManInfo());
            }

            // Определите выражение запроса.
            personQuery = persons.OrderByDescending(p => p.Age);
                //from person in persons
                //orderby person.Age descending
                //select person;

            Console.WriteLine("Отсортированная коллекция по убыванию.");
            foreach (var i in personQuery)
            {
                Console.WriteLine(i.ManInfo());
            }

            Console.ReadLine();
        }
    }
}
