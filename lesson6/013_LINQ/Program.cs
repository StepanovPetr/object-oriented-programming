﻿using System;
using System.Collections.Generic;
using System.Linq;

// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/join-clause#left-outer-join
namespace _013_LINQ
{
    class Program
    {
        // Пример Левого внуреннего соединения.
        static void Main(string[] args)
        {
            List<Man> persons = new List<Man>() { Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan() };
            List<Сity> cities = new List<Сity>() { new Сity() { Name ="Омск", Population=10000, Mayor="Оксана"},
                new Сity() { Name = "Москва", Population = 1000000, Mayor = "Сергей" },
                new Сity() { Name = "Хацупетовка", Population = 10, Mayor = "Денис Борисов" },
                new Сity() { Name = "Томск", Population = 10, Mayor = "Вася" },
                new Сity() { Name = "Махачкала", Population = 10, Mayor = "Конор" },
            };

            Console.WriteLine("Список людей:");
            foreach (var person in persons)
            {
                Console.WriteLine(person.ManInfo());
            }
            Console.WriteLine();

            Console.WriteLine("Список городов:");
            foreach (var city in cities)
            {
                Console.WriteLine(city.ManInfo());
            }
            Console.WriteLine();


            var queryMenByFirstName =
            from person in persons
             // // Пример левого внешнего соединения.я двух таблиц по названию города.
            join city in cities on person.City equals city.Name
            select new { person.FirstName, person.Age, city.Name, city.Population, city.Mayor };

            foreach (var person in queryMenByFirstName)
            {
                Console.WriteLine("Имя - {0}, Возраст - {1} Название города - {2} Население - {3} Мэр - {4}", person.FirstName, person.Age, person.Name, person.Population, person.Mayor);
            }
            Console.ReadLine();
        }
    }
}
