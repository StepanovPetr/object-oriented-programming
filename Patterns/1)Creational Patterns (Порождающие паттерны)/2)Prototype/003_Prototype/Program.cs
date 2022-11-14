using System;
using Prototype;

namespace _003_Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var man = new Man();
            var manClone = (Man)man.Clone();

            Console.WriteLine($"prototype - {man.ManInfo()} {Environment.NewLine}clone - {manClone.ManInfo()}");
        }
    }
}
