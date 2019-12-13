using System;
using System.IO;

//https://docs.microsoft.com/en-us/dotnet/api/system.io.directory.getfiles?view=netframework-4.5
//https://docs.microsoft.com/en-us/dotnet/api/system.io.directory.getdirectories?view=netframework-4.5
namespace _12_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string DriveC = @"C:\";
            string DriveD = @"D:\";
          
            string[] fileEntries = Directory.GetFiles(DriveC);
            string[] directoriesEntries = Directory.GetDirectories(DriveC);
            Console.WriteLine("Файлы C:\\");
            foreach (string fileName in fileEntries)
                Console.WriteLine(fileName);
            Console.WriteLine("Папки C:\\");
            foreach (string fileName in directoriesEntries)
                Console.WriteLine(fileName);

            fileEntries = Directory.GetFiles(DriveD);
            directoriesEntries = Directory.GetDirectories(DriveD);
            Console.WriteLine("Файлы D:\\");
            foreach (string fileName in fileEntries)
                Console.WriteLine(fileName);
            Console.WriteLine("Папки D:\\");
            foreach (string fileName in directoriesEntries)
                Console.WriteLine(fileName);

            Console.ReadLine();
        }
    }
}
