using System;
using System.IO;

//https://docs.microsoft.com/ru-ru/dotnet/api/system.io.path.changeextension?view=netframework-4.5
namespace _08_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            string goodFileName = @"C:\mydir\myfile.com.extension";
            string badFileName = @"C:\mydir\";
            string result;


            result = Path.ChangeExtension(goodFileName, ".old");
            Console.WriteLine("ChangeExtension({0}, '.old') returns '{1}'",
                goodFileName, result);

            result = Path.ChangeExtension(goodFileName, "");
            Console.WriteLine("ChangeExtension({0}, '') returns '{1}'",
                goodFileName, result);

            result = Path.ChangeExtension(badFileName, ".old");
            Console.WriteLine("ChangeExtension({0}, '.old') returns '{1}'",
                badFileName, result);
            Console.ReadLine();
        }
    }
}
