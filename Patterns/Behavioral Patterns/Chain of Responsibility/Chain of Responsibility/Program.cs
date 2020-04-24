using System;
using Chain_of_Responsibility.Enums;

namespace Chain_of_Responsibility
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var s = new Student("Вася", Faculty.Fitix);
            var s2 = new Student("Коля", Faculty.Msi);
            var s3 = new Student("Эскобар", Faculty.Fgo);

            AbstractHandler fitixHandler = new FitixHandler();
            AbstractHandler msiHandler = new MsiHandler();

            fitixHandler.SetNext(msiHandler);

            fitixHandler.Handle(s);
            fitixHandler.Handle(s2);
            fitixHandler.Handle(s3);

            Console.ReadLine();
        }
    }
}