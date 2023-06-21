using System;
using System.IO;

namespace _012_Directory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var disks = new [] {@"C:\", @"D:\"};

            foreach (var disk in disks)
            {
                var fileEntries = Directory.GetFiles(disk);
                var directoriesEntries = Directory.GetDirectories(disk);

                Console.WriteLine($"Файлы {disk}");
                foreach (var fileName in fileEntries)
                    Console.WriteLine(fileName);

                Console.WriteLine($"Папки {disk}");
                foreach (var fileName in directoriesEntries)
                    Console.WriteLine(fileName);

                Console.WriteLine(new string('-',120));
            }
            Console.ReadLine();
        }
    }
}