using System;
using System.Collections;

namespace _10_ArrayList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var myList = new ArrayList();

            var s = "Hello";
            myList.Add(s);
            myList.Add("Word");
            myList.Add(666);
            myList.Add(new object());

            foreach (var item in myList)
                Console.WriteLine(item.ToString());

            Console.ReadLine();
        }
    }
}