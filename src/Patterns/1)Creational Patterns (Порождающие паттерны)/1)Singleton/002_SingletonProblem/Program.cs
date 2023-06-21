using System;
using System.Threading;
using LibExample;

namespace _002_SingletonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var instance1 = SingletonSimpleProblem.Instance();
            //var instance2 = SingletonSimpleProblem.Instance();
            //Console.WriteLine($"instance1 - {instance1.GetHashCode()}");
            //Console.WriteLine($"instance2 - {instance2.GetHashCode()}");
            //Console.ReadLine();

            Thread thread = new Thread(t => Console.WriteLine($"instance2 - {SingletonSimpleProblem.Instance().GetHashCode()}"));
            thread.Start();

            var instance1 = SingletonSimpleProblem.Instance();
            Console.WriteLine($"instance1 - {instance1.GetHashCode()}");
            Console.ReadLine();
        }
    }
}
