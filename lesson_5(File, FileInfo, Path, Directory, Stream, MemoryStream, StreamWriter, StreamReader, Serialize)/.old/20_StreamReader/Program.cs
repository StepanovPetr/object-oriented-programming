using System;
using System.IO;

namespace _20_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Поменять FileAccess.Write.
            using (Stream stream = new FileStream("Test.dat", FileMode.OpenOrCreate, FileAccess.Read))
            {                
                StreamReader streamReader = new StreamReader(stream);
                while(!streamReader.EndOfStream)
                    //  Считывание построчно.
                    Console.WriteLine(streamReader.ReadLine());

                stream.Position = 0;
                //  Считывание всего файла в строку.
                Console.WriteLine(streamReader.ReadToEnd());
                Console.ReadLine();
            }
        }
    }
}
