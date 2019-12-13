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
                    Console.WriteLine( streamReader.ReadLine());

                Console.ReadLine();
            }
        }
    }
}
