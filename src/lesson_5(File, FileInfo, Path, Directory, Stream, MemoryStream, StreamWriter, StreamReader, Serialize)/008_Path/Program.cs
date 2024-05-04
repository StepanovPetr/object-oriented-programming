using System;
using System.IO;

namespace _008_Path
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var goodFileName = @"C:\mydir\myfile.com";
            var badFileName = @"C:\mydir\";

            var result = Path.ChangeExtension(goodFileName, ".old");
            Console.WriteLine($"ChangeExtension({goodFileName},  '.old') returns '{result}' ");

            result = Path.ChangeExtension(goodFileName, "");
            Console.WriteLine($"ChangeExtension({goodFileName},  '') returns '{result}'");

            result = Path.ChangeExtension(badFileName, ".old");
            Console.WriteLine($"ChangeExtension({badFileName},  '.old') returns '{result}'");

            Console.ReadLine();
        }
    }
}