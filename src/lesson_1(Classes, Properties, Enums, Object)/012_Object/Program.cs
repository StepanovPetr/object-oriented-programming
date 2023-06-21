using System;
using LibExample;

namespace _012_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            string manToString = man.ToString();

            Console.WriteLine(manToString);
        }
    }
}
