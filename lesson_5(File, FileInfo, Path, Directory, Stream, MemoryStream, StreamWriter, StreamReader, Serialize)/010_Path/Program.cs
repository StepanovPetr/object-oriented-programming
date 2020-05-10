using System;
using System.IO;

namespace _010_Path
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var goodFileName = @"Example.txt";
            var badFileName = @"Example.txt.bak";

            Console.WriteLine("Получение полного пути к файлу");
            Console.WriteLine(Path.GetFullPath(goodFileName));
            Console.WriteLine(Path.GetFullPath(badFileName));
            Console.ReadLine();
        }
    }
}