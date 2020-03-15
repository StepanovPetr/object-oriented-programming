using System;
using System.IO;

https://docs.microsoft.com/en-us/dotnet/api/system.io.fileinfo.copyto?view=netframework-4.8
namespace _07_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fileInfo = new FileInfo("Example.txt");
            fileInfo.CopyTo("Example.txt.bak");
            fileInfo.CopyTo("ExampleNew.txt.bak");
            //fileInfo.CopyTo("ExampleNew.txt.bak");
            fileInfo.CopyTo("ExampleNew.txt.bak", true);

            fileInfo.MoveTo("Example.MoveTo.txt");
            //fileInfo.("Example.MoveTo.txt");
        }
    }
}
