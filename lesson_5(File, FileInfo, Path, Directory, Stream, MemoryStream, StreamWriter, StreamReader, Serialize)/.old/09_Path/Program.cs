using System;
using System.IO;

//https://docs.microsoft.com/en-us/dotnet/api/system.io.path.getfilename?view=netframework-4.5
//https://docs.microsoft.com/en-us/dotnet/api/system.io.path.getfilenamewithoutextension?view=netframework-4.5
//https://docs.microsoft.com/en-us/dotnet/api/system.io.path.getextension?view=netframework-4.5
//https://docs.microsoft.com/en-us/dotnet/api/system.io.path.getdirectoryname?view=netframework-4.5
//https://docs.microsoft.com/en-us/dotnet/api/system.io.path.getpathroot?view=netframework-4.5
namespace _09_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            string goodFileName = @"C:\mydir\myfile.com";
            string badFileName = @"C:\mydir\";

            Console.WriteLine("Получение имени файла");
            Console.WriteLine(Path.GetFileName(goodFileName));
            Console.WriteLine(Path.GetFileName(badFileName));

            Console.WriteLine("Получение имени файла без расширения");
            Console.WriteLine(Path.GetFileNameWithoutExtension(goodFileName));
            Console.WriteLine(Path.GetFileNameWithoutExtension(badFileName));

            Console.WriteLine("Получение расширения файла");
            Console.WriteLine(Path.GetExtension(goodFileName));
            Console.WriteLine(Path.GetExtension(badFileName));

            Console.WriteLine("Получение папки в которой расположен файл");
            Console.WriteLine(Path.GetDirectoryName(goodFileName));
            Console.WriteLine(Path.GetDirectoryName(badFileName));

            Console.WriteLine("Получение корневой директории  в которой расположен файл");
            Console.WriteLine(Path.GetPathRoot(goodFileName));
            Console.WriteLine(Path.GetPathRoot(badFileName));

            Console.ReadLine();
        }
    }
}
