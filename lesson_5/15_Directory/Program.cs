using System;
using System.IO;

// https://docs.microsoft.com/en-us/dotnet/api/system.io.directory.move?view=netframework-4.5
namespace _15_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Example";
            string pathMove = "ExampleMove";
            // Пример создание директории.
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            for (int i = 0; i < 10; i++)
                File.Create(Path.Combine(path, Path.GetRandomFileName())).Dispose();

            Directory.Move(Path.GetFullPath(path), Path.GetFullPath(pathMove));

        }
    }
}
