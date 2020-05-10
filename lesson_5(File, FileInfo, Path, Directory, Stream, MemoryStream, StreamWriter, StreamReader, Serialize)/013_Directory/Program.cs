using System;
using System.IO;

namespace _013_Directory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Получение текущей директории.
            var path = Directory.GetCurrentDirectory();
            Console.WriteLine(path);

            // Установка текущей директории .. -- директория на уровень выше.
            Directory.SetCurrentDirectory(@"..\");
            Console.WriteLine(Directory.GetCurrentDirectory());

            // Установка текущей директории.
            Directory.SetCurrentDirectory("C:\\");
            Console.WriteLine(Directory.GetCurrentDirectory());

            // Получение корневой директории.
            Console.WriteLine(Directory.GetDirectoryRoot(path));

            Console.ReadLine();
        }
    }
}