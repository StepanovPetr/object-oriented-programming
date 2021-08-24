using System;
using LibExample;

namespace _005_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            FlatFromInterface flat = new FlatFromInterface();
            IBuilding building = flat;
            //IPlace place = flat;
            Console.ReadLine();
        }
    }
}
