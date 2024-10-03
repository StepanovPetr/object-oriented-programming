using System;

namespace _14_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // StackOverflowException
                RecursiveMethod();
            }

            catch (Exception e)
            {
                Console.WriteLine("Исключение обработано.");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.GetType().Namespace);
            }
        }

        private static void RecursiveMethod()
        {
            var intVar = 0;
            var boolVar = true;

            RecursiveMethod();
        }
    }
}
