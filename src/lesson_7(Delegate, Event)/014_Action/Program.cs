using System;
using LibExample;

namespace _014_Action
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> doSomething = SimpleClass.Method4;

            doSomething("Write Something");
        }
    }
}
