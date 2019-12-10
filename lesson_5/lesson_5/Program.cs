using System;
using System.Collections.Generic;
using System.IO; // необходимое пространство имен для работы с файлама, папками, дисками и файловыми потоками

namespace lesson_5
{
    // https://docs.microsoft.com/en-us/dotnet/api/system.io?view=netframework-4.8
    // https://docs.microsoft.com/en-us/dotnet/api/system.io.driveinfo?view=netframework-4.8
    class Program
    {
        static void Main(string[] args)
        { 
            // Получение списка дисков.
            DriveInfo[] disks =  DriveInfo.GetDrives();
            // Вывод информации и каждом диске.
            foreach (var disk in disks)
            {
                Console.WriteLine("Disk Name -- {0}", disk.Name);
                Console.WriteLine("Disk Format -- {0}", disk.DriveFormat);
                Console.WriteLine("Disk Type -- {0}", disk.DriveType);
                Console.WriteLine("Value -- {0}", disk.TotalSize);
                Console.WriteLine("Free Value -- {0}", disk.TotalFreeSpace);

                //Получение информации о кореневой директории диска.
                DirectoryInfo folders = disk.RootDirectory;

                //Получение списка папок директории 
                foreach (var folder in folders.GetDirectories())
                    Console.WriteLine("   Directory - {0}", folder);

                //Получение списка файлов директории 
                foreach (var file in folders.GetFiles())
                    Console.WriteLine("   file - {0}", file);

                Console.WriteLine();
            }
           Console.ReadKey();
        }
    }
}
