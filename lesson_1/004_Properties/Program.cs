﻿using System;

namespace _004_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Man person = new Man();
            Console.WriteLine($"{person.FirstName}, {person.SecondName}, {person.Age}");
            person.FirstName = "Ivan";
            Console.WriteLine($"{person.FirstName}, {person.SecondName}, {person.Age}");
            Console.ReadKey();
        }
    }
}
