using System;

namespace _7_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firsClass = new FirstClass();
            var secondClass = new SecondClass();

            DoSomething(firsClass);
            DoSomething(secondClass);

            Console.ReadLine();
        }

        static void DoSomething(IMyInterface myInterface)
        {
            Console.WriteLine(myInterface.DoSomething(2));
        }
    }
}
