using System;
using System.IO;

namespace _014_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Example";
            // Пример создания директории.
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            // Дата создания директории.
            Console.WriteLine(Directory.GetCreationTime(path));
            // Дата последнего доступа к директории.
            Console.WriteLine(Directory.GetLastAccessTime(path));

            // Изменение даты создания и даты последнего доступа. 
            Directory.SetCreationTime(path, new DateTime(1666, 12, 31));
            Directory.SetLastAccessTime(path, new DateTime(1667, 1, 1));

            Console.WriteLine(Directory.GetCreationTime(path));
            Console.WriteLine(Directory.GetLastAccessTime(path));
            Console.ReadLine();
        }
    }
}
