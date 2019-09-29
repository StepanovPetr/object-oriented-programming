using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{

    class Man
    {
        public string FirstName;
        public string SecondName;
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Создание экземпляра класса Man с именем person.
            Man person =  new Man();
            person.FirstName = "Ivan";
            person.SecondName = "Ivanov";
            person.Age = 33;
            Console.WriteLine("FirstName - {0} SecondName - {1} Age - {2}", person.FirstName, person.SecondName, person.Age);
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated Стандарт C# 6
            // Console.WriteLine($"FirstName - {person.FirstName} SecondName - {person.SecondName} Age - {person.Age}");
            Console.Read();
        }
    }
}
