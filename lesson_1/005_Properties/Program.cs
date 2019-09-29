using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Man person = new Man();
            person.Age = 0;
            person.Age = 200;
            person.Age = 110;
            Console.WriteLine($"{person.Age}");
            Console.WriteLine($"{person.FirstName}");
            Console.ReadKey();
        }
    }
}
