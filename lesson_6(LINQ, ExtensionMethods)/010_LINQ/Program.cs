﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _010_LINQ
{
    class Program
    {
        // Выборка значений.
        static void Main(string[] args)
        {
            List<Man> persons = new List<Man>() { Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan() };

            var queryMenByFirstName =
            from person in persons
            select new {person.FirstName, person.Age};

            foreach (var person in queryMenByFirstName)
            {
                Console.WriteLine("{0}-{1}",person.FirstName, person.Age );
            }
            Console.ReadLine();
        }
    }
}
