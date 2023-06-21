using System;
using System.Collections.Generic;

namespace lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<int, Man>();
            dict[3] = Man.GetMan();
            dict[4] = Man.GetMan();
            dict[1] = Man.GetMan();
            dict[2] = Man.GetMan();
            dict[5] = Man.GetMan();
            dict[6] = Man.GetMan();
            dict[7] = Man.GetMan();

            Man str = dict[3];

            foreach (KeyValuePair<int, Man> i in dict)
            {
                Console.WriteLine("{0} = {1}", i.Key, i.Value);
            }

            Console.WriteLine(new string('-', 25));

            foreach (var value in dict.Values)
            {
                Console.WriteLine(value);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
