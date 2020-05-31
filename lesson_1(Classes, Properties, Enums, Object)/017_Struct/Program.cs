using System;
using LibExample;

namespace _017_Struct
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var classExample = new ClassExample(true, 111, 55.44);
            var classExampleCopy = classExample;

            classExample.Field1 = false;
            classExample.Field2 = 222;
            classExample.Field3 = 111.222;

            Console.WriteLine("Пример присвоения ссылки.");
            Console.WriteLine(classExample.Info);
            Console.WriteLine(classExampleCopy.Info);

            var structExample = new StructExample(true, 111, 55.44);
            var structExampleCopy = structExample;

            structExample.Field1 = false;
            structExample.Field2 = 222;
            structExample.Field3 = 111.222;

            Console.WriteLine("Пример присвоения значения.");
            Console.WriteLine(structExample.Info);
            Console.WriteLine(structExampleCopy.Info);

            Console.ReadLine();
        }
    }
}