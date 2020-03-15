using System;
using System.IO;

// https://docs.microsoft.com/en-us/dotnet/api/system.io.directory.createdirectory?view=netcore-3.1
namespace _14_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Example";
            // Пример создание директории.
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            Console.WriteLine(Directory.GetCreationTime(path));
            Console.WriteLine(Directory.GetLastAccessTime(path));

            Directory.SetCreationTime(path, new DateTime(1666, 12, 31));
            Directory.SetLastAccessTime(path, new DateTime(1667, 1, 1));

            Console.WriteLine(Directory.GetCreationTime(path));
            Console.WriteLine(Directory.GetLastAccessTime(path));
            Console.ReadLine();
        }
    }
}
