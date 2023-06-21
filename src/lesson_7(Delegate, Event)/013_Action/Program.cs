using System;
using LibExample;

// https://learn.microsoft.com/ru-ru/dotnet/api/system.action-1?view=net-7.0
namespace _013_Action
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleClass simpleClass = new SimpleClass();

            Action doSomething = SimpleClass.Method3;
            doSomething += simpleClass.Method1;
            doSomething += simpleClass.Method2;

            doSomething();
        }
    }
}
