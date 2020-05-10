using System.IO;

namespace _003_File
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Пример создания файла.
            File.Create("Example.txt").Dispose();

            // Пример добавления текста в конец файла.
            File.AppendAllText("Example.txt", "Some text");

            // Получение аттрибутов файла.
            var fileAttributes = File.GetAttributes("Example.txt");
        }
    }
}