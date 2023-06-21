using System;

namespace _8_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOld;
            int age = int.Parse(Console.ReadLine());

            if (age > 60)
            {
                isOld = true;
            }
            else
            {
                isOld = false;
            }

            // Тернарный if.
            isOld = (age > 60) ? true : false;

            Console.ReadLine();
        }
    }
}
