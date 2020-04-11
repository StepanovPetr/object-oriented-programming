using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IDraw targer = new Adapter();
            targer.Draw();
            Console.ReadLine();
        }
    }
}
