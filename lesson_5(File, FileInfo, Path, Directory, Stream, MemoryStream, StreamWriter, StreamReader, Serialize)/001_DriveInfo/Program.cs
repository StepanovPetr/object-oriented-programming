using System;
// Необходимое пространство имен для работы с файлама, папками, дисками и файловыми потоками.
using System.IO;

#region Links

// https://docs.microsoft.com/en-us/dotnet/api/system.io?view=netframework-4.8
// https://docs.microsoft.com/en-us/dotnet/api/system.io.driveinfo?view=netframework-4.8

#endregion

namespace DriveInfo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Получение списка дисков.
            var disks = System.IO.DriveInfo.GetDrives();

            // Вывод информации и каждом диске.
            foreach (var disk in disks)
            {
                Console.WriteLine("Disk Name -- {0}", disk.Name);
                Console.WriteLine("Disk Format -- {0}", disk.DriveFormat);
                Console.WriteLine("Disk Type -- {0}", disk.DriveType);
                Console.WriteLine("Value -- {0}", disk.TotalSize);
                Console.WriteLine("Free Value -- {0}", disk.TotalFreeSpace);

                // Получение информации о кореневой директории диска.
                var folders = disk.RootDirectory;

                // Получение списка директорий директории. 
                foreach (var folder in folders.GetDirectories())
                    Console.WriteLine($"   Directory - {folder}");

                // Получение списка файлов директории. 
                foreach (var file in folders.GetFiles())
                    Console.WriteLine($"   file - {file}");

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}