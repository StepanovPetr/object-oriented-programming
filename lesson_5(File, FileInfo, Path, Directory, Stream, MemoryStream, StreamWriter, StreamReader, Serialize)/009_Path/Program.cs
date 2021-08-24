using System;
using System.IO;

namespace _009_Path
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var goodFileName = @"C:\mydir\myfile.com";
            var badFileName = @"C:\mydir\";

            Console.WriteLine("Получение имени файла");
            Console.WriteLine(Path.GetFileName(goodFileName));
            Console.WriteLine(Path.GetFileName(badFileName));

            Console.WriteLine("Получение имени файла без расширения");
            Console.WriteLine(Path.GetFileNameWithoutExtension(goodFileName));
            Console.WriteLine(Path.GetFileNameWithoutExtension(badFileName));

            Console.WriteLine("Получение расширения файла");
            Console.WriteLine(Path.GetExtension(goodFileName));
            Console.WriteLine(Path.GetExtension(badFileName));

            Console.WriteLine("Получение папки, в которой расположен файл");
            Console.WriteLine(Path.GetDirectoryName(goodFileName));
            Console.WriteLine(Path.GetDirectoryName(badFileName));

            Console.WriteLine("Получение корневой директории,  в которой расположен файл");
            Console.WriteLine(Path.GetPathRoot(goodFileName));
            Console.WriteLine(Path.GetPathRoot(badFileName));

            Console.ReadLine();
        }
    }
}