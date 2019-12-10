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

                using (var stream = File.OpenRead("04_File.exe"))
                {
                    Console.WriteLine(Encoding.Default.GetString(md5.ComputeHash(stream)));
                }

                using (var stream = File.OpenRead("Copy04"))
                {
                    Console.WriteLine(Encoding.Default.GetString(md5.ComputeHash(stream)));
                }

                using (var stream = File.OpenRead("CopyCopy04"))
                {
                    Console.WriteLine(Encoding.Default.GetString(md5.ComputeHash(stream)));
                }

                using (var stream = File.OpenRead("Example.txt"))
                {
                    Console.WriteLine(Encoding.Default.GetString(md5.ComputeHash(stream)));
                }
            }
            Console.ReadLine();
        }

    }
}
