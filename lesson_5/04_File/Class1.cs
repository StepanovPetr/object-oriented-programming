using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace _04_File
{
    public class Class1
    {
        static void Main(string[] args)
        {
            using (var md5 = MD5.Create())
            {
                File.Copy("04_File.exe", "Copy04");
                File.Copy("Copy04", "CopyCopy04");

                var stream = File.OpenRead("04_File.exe");
                using (stream)
                {
                    // Пример получения Md5 хеша файла.
                    Console.WriteLine(Encoding.Default.GetString(md5.ComputeHash(stream)));
                }

                using (var stream2 = File.OpenRead("Copy04"))
                {
                    // Пример получения Md5 хеша файла.
                    Console.WriteLine(Encoding.Default.GetString(md5.ComputeHash(stream)));
                }

                using (var stream3 = File.OpenRead("CopyCopy04"))
                {
                    // Пример получения Md5 хеша файла.
                    Console.WriteLine(Encoding.Default.GetString(md5.ComputeHash(stream)));
                }

                using (var stream4 = File.OpenRead("Example.txt"))
                {
                    // Пример получения Md5 хеша файла.
                    Console.WriteLine(Encoding.Default.GetString(md5.ComputeHash(stream)));
                }
            }
            Console.ReadLine();
        }

    }
}
