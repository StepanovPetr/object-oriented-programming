using System;
using LibExample;

namespace _016_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string, int, string> doSomething = SimpleClass.Method4WithReturnValue;

            Console.WriteLine(doSomething("Василий", "Пупкин", 18));
        }
    }
}
