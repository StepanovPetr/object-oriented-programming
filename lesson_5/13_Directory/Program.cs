using System;
using System.IO;

//https://docs.microsoft.com/en-us/dotnet/api/system.io.directory.getcurrentdirectory?view=netframework-4.5
namespace _13_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Получение текущей директории.
            string path = Directory.GetCurrentDirectory();
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
