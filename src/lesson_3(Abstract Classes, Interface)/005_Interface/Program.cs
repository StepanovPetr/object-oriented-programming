using System;
using LibExample.Interface;

namespace _005_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Flat flat = new Flat();
            IBuilding building = flat;
            IPlace place = flat;
        
            Console.ReadLine();
        }
    }
}
