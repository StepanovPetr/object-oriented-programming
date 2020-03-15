using System;
using System.IO;

//https://docs.microsoft.com/en-us/dotnet/api/system.io.path.getfullpath?view=netframework-4.5
namespace _10_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            string goodFileName = @"Example.txt";
            string badFileName = @"Example.txt.bak";

            Console.WriteLine("Получение полного пути к файлу");
            Console.WriteLine(Path.GetFullPath(goodFileName));
            Console.WriteLine(Path.GetFullPath(badFileName));
            Console.ReadLine();
        }
    }
}
