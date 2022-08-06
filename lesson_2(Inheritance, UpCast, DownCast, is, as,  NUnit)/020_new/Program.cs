using System;

namespace _020_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = 10;
            RefExample(obj);
            Console.WriteLine(obj);

            RefExample2(obj);
            Console.WriteLine(obj);

            Console.ReadLine();
        }

        static void RefExample(object obj)
        {
            obj = null;
        }

        static void RefExample2(object obj)
        {
            obj = 12;
        }
    }
}
