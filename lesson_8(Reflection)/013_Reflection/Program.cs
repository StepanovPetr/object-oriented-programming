using System;
using System.Reflection;

namespace _013_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lib = Assembly.LoadFrom("Lib/LibExample.dll");

            var types = lib.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine(type.FullName);
            }


            Console.WriteLine("Hello World!");
        }
    }
}
