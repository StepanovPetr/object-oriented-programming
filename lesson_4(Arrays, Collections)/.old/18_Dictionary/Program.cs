using System;
using System.Collections.Generic;

namespace _18_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<int, string>();
            dict[3] = "Windows 95";
            dict[4] = "Windows 98";
            dict[1] = "Windows ME";
            dict[2] = "Windows XP";
            dict[5] = "Windows 7";
            dict[6] = "Windows 8";
            dict[7] = "Windows 10";

            string str = dict[3];

            foreach (KeyValuePair<int, string> i in dict)
                Console.WriteLine("{0} = {1}", i.Key, i.Value);
            
            Console.WriteLine(new string('-', 25));

            foreach (var value in dict.Values)
                Console.WriteLine(value);
            
            Console.ReadKey();
        }
    }
}
