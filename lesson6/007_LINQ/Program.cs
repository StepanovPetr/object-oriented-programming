using System;
using System.Collections.Generic;
using System.Linq;

// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/basic-linq-query-operations#grouping
namespace _007_LINQ
{
    class Program
    {
        //Пример группировки
        static void Main(string[] args)
        {
            List<Man> persons = new List<Man>() { Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan(), Man.GetMan() };

               var queryMenByFirstName =
               from person in persons
               // Группировка по полю FirstName;
               group person by person.FirstName;

            // customerGroup is an IGrouping<string, Customer>
            foreach (var manGroup in queryMenByFirstName)
            {
                Console.WriteLine(manGroup.Key);
                foreach (var person in manGroup)
                {
                    Console.WriteLine(person.ManInfo());
                }
            }
            Console.ReadLine();
        }
    }
}
