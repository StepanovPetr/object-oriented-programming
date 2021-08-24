using System.IO;

namespace _015_Directory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var path = "Example";
            var pathMove = "ExampleMove";
            // Пример создание директории.
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            for (var i = 0; i < 10; i++)
                File.Create(Path.Combine(path, Path.GetRandomFileName())).Dispose();

            // Пример перемещения директории.
            Directory.Move(Path.GetFullPath(path),
                Path.GetFullPath(pathMove));
        }
    }
}