using System.IO;

namespace _005_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляра FileInfo.
            FileInfo fileInfo = new FileInfo("Example.txt");
            // Cоздание файла. 
            FileStream filestream = fileInfo.Create();
            // Закрытие потока с файлом.
            filestream.Close();
            // Удаление файла.
            fileInfo.Delete();
        }
    }
}
