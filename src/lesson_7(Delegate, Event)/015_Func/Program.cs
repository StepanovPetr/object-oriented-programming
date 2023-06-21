using System;
using LibExample;

namespace _015_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string> doSomething = SimpleClass.Method3WithReturnValue;

            Console.WriteLine(doSomething());
        }
    }
}
