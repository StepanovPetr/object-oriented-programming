using System.IO; // необходимое пространство имен для работы с файлама, папками, дисками и файловыми потоками
namespace _03_File
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример создания файла.
            File.Create("Example.txt").Dispose();

            // Пример добавления текста в конец файла.
            File.AppendAllText("Example.txt", "Some text");

            // Получение аттрибутов файла.
            FileAttributes fileAttributes = File.GetAttributes("Example.txt");

        }
    }
}
