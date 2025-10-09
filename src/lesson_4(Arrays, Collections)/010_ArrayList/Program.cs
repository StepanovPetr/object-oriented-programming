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

            myList = new ArrayList();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"i = {i} Count = {myList.Count} Capacity = {myList.Capacity} ");
                myList.Add(i);
            }

            Console.ReadLine();
        }
    }
}