using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Man person = new Man();
            //Console.WriteLine(person.FirstName);
            // person.FirstName = "Энакин";

            //Console.WriteLine(person.SecondName);
            person.SecondName = "Скайуокер";
            Console.ReadKey();
        }
    }
}
