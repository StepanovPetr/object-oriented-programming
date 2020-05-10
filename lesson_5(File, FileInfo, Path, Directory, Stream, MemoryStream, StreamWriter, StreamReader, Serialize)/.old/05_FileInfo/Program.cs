using System;
using System.IO;    

//https://docs.microsoft.com/en-us/dotnet/api/system.io.fileinfo.create?view=netframework-4.8#System_IO_FileInfo_Create
namespace _05_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляра FileInfo
            FileInfo fileInfo = new FileInfo("Example.txt");
            // Cоздаение файла 
            FileStream millstream = fileInfo.Create();
            // Закрытие потока с файлом
            millstream.Dispose();
            // Удаление файла
            fileInfo.Delete();
        }
    }
}
