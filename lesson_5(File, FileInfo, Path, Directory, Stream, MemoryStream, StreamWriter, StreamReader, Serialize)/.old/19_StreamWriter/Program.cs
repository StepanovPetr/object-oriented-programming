using System;
using System.IO;

//  https://docs.microsoft.com/en-us/dotnet/api/system.io.streamwriter.writeline?view=netcore-3.1&viewFallbackFrom=netframework-4.5
namespace _19_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Stream stream = new FileStream("Test.dat", FileMode.Open, FileAccess.ReadWrite))
            {
                StreamWriter streamWriter = new StreamWriter(stream);
                streamWriter.Write("1");
                streamWriter.Write(streamWriter.NewLine);
                streamWriter.Write("Example add String");
                Console.ReadLine();
            }
        }
    }
}
