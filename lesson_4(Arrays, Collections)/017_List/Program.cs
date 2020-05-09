using System;
using System.Collections.Generic;
using LibExample;

namespace _017_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример List работающего с пользовательскими классами.
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
                Console.WriteLine(item.ManInfo());

            Console.ReadKey();
        }
    }
}