using System;
using System.IO;   

//https://docs.microsoft.com/en-us/dotnet/api/system.io.fileinfo.open?view=netframework-4.8
namespace _06_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fileInfo = new FileInfo("Example.txt");
            using (FileStream fs = fileInfo.Open(FileMode.Open))
            {
                Console.ReadLine();
            }

            using (FileStream fs = fileInfo.Open(FileMode.Open, FileAccess.Read))
            {
                Console.ReadLine();
            }

            using (FileStream fs = fileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                Console.ReadLine();
            }
        }
    }
}
