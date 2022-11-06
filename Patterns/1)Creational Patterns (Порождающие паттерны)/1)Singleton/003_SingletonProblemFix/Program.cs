using System;
using System.Threading;
using LibExample;

namespace _003_SingletonProblemFix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(t => Console.WriteLine($"instance2 - {SingletonSimpleProblemFix.Instance().GetHashCode()}"));
            thread.Start();

            var instance1 = SingletonSimpleProblemFix.Instance();
            Console.WriteLine($"instance1 - {instance1.GetHashCode()}");
            Console.ReadLine();
        }
    }
}
