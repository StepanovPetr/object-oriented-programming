﻿using System;
using System.Collections.Generic;
using System.Linq;
using LibExample;

// https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.join?view=netframework-4.8
namespace _026_LINQ
{
    class Program
    {
        // Пример Левого внуреннего соединения.
        static void Main(string[] args)
        {
            List<Man> persons = new List<Man>() { Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan() };
            List<City> cities = new List<City>() { new City() { Name ="Омск", Population=10000, Mayor="Оксана"},
                new City() { Name = "Москва", Population = 1000000, Mayor = "Сергей" },
                new City() { Name = "Хацупетовка", Population = 10, Mayor = "Денис Борисов" },
                new City() { Name = "Томск", Population = 10, Mayor = "Вася" },
                new City() { Name = "Махачкала", Population = 10, Mayor = "Конор" },
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

            // Пример левого внешнего соединения.я двух таблиц по названию города.
            var queryMenByFirstName = persons.Join(cities,
                    person => person.City,
                    city => city.Name,
                    (p, c) => new { p.FirstName, p.Age, c.Name, c.Population, c.Mayor});

            //from person in persons                
            //join city in cities on person.City equals city.Name
            //select new { person.FirstName, person.Age, city.Name, city.Population, city.Mayor };

            foreach (var person in queryMenByFirstName)
            {
                Console.WriteLine("Имя - {0}, Возраст - {1} Название города - {2} Население - {3} Мэр - {4}", person.FirstName, person.Age, person.Name, person.Population, person.Mayor);
            }
            Console.ReadLine();
        }
    }
}
