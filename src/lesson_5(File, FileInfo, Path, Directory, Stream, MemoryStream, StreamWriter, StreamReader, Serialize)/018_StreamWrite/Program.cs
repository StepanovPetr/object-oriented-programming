using System;
using System.IO;

namespace _018_StreamWrite
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if(File.Exists("Test.dat"))
                File.Create("Test.dat").Dispose();

            using (var streamWriter = new StreamWriter("Test.dat"))
            {
                streamWriter.Write("1");
                streamWriter.Write(streamWriter.NewLine);
                streamWriter.Write("Example add String");
                Console.ReadLine();
            }

            using (StreamReader streamReader = new StreamReader("Test.dat"))
            {
                while (!streamReader.EndOfStream)
                    //  Считывание построчно.
                    Console.WriteLine(streamReader.ReadLine());

                streamReader.BaseStream.Position = 0;
                //  Считывание всего файла в строку.
                Console.WriteLine(streamReader.ReadToEnd());
                Console.ReadLine();
            }
        }
    }
}