using System;

namespace _008_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Man firstMan = new Man();
         
            Console.WriteLine(firstMan.ManInfo());
            firstMan  = firstMan + 60;
            Console.WriteLine(firstMan.ManInfo());

            firstMan = new Man();
            Man secondMan = new Man();

            string result = (firstMan == secondMan) 
                ? "Значения равны" 
                : "Значения не равны";

            Console.WriteLine(result);

            secondMan.FirstName = "Ivan";
            result = (firstMan == secondMan)
                ? "Значения равны" 
                : "Значения не равны";

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
