using System;
using System.Collections.Generic;

namespace lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // пример List работающего с пользовательскими классами
            List<Man> men = new List<Man>();
            men.Add(Man.GetMan());
            men.Add(Man.GetMan());
            men.Add(Man.GetMan());
            men.Add(Man.GetMan());
            men.Add(Man.GetMan());
            men.Add(Man.GetMan());
            men.Add(Man.GetMan());
            men.Add(Man.GetMan());

            foreach (var item in men)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
