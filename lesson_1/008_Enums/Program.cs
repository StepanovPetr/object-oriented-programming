using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Man firstMan = new Man();
            Man seconMan = new Man();
            seconMan.FirstName = "Ivan";

            string result = (firstMan == seconMan) ? "Значения равны" : "Значения не равны";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
