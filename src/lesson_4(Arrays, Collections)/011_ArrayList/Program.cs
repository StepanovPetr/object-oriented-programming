using System;
using System.Collections;

namespace _011_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new ArrayList();

            string[] anArray = new string[] { "Hello", "Word" };
            myList.AddRange(anArray);

            foreach (var item in myList)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();

            myList.Insert(1, "OmGTU");

            foreach (var item in myList)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();

            var moreString = new[] { "goodnight", "see ya" };
            myList.InsertRange(1, moreString);

            foreach (var item in myList)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
