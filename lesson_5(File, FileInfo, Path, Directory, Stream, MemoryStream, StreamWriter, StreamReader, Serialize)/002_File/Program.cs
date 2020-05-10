using System.IO;

namespace _002_File
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Пример создания файла.
            File.Create("Example.txt").Dispose();

            // Пример добавления текста в конец файла.
            File.AppendAllText("Example.txt", "Some text");

            // Пример копирования файла.
            File.Copy("Example.txt", "Example2.txt");

            // Перемещения файла.
            File.Move("Example2.txt", "Example3.txt");

            // Пример проверки существования файла.
            if (File.Exists("Example.txt"))
                //Пример удаления файла.
                File.Delete("Example.txt");
        }
    }
}