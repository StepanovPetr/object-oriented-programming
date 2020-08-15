using System;
using LibExample;

namespace _018_Struct
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var classExample = new ClassExample(true, 111, 55.44);
            ClassMethod(classExample);

            Console.WriteLine("Пример передачи в метод экземпляра класса.");
            Console.WriteLine(classExample.Info);

            var structExample = new StructExample(true, 111, 55.44);
            StructMethod(structExample);

            Console.WriteLine("Пример передачи в метод экземпляра структуры.");
            Console.WriteLine(structExample.Info);
            Console.ReadLine();
        }

        // Классы передают в метод ссылку.
        private static void ClassMethod(ClassExample classExample)
        {
            classExample.Field1 = false;
            classExample.Field2 = 222;
            classExample.Field3 = 111.222;
        }

        // Структуры копируют значение.
        private static void StructMethod(StructExample localExample)
        {
            localExample.Field1 = false;
            localExample.Field2 = 222;
            localExample.Field3 = 111.222;
        }
    }
}