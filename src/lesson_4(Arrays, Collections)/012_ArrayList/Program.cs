using System;
using System.Collections;

namespace _012_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new ArrayList();
            string[] anArray = { "Hello", "Word" };
            myList.AddRange(anArray);
            myList.Insert(1, "OmGTU");
            var moreString = new[] { "goodnight", "see ya" };
            myList.InsertRange(1, moreString);

            Console.WriteLine("Before remove");
            Console.WriteLine("--------------");
            foreach (var item in myList)
                Console.WriteLine(item.ToString());
            
            // Поиск элемента.
            int index = myList.IndexOf("Hello");
            Console.WriteLine(index);
            Console.ReadLine();

            myList.RemoveAt(0);
            myList.RemoveRange(0, 2);

            Console.WriteLine("After remove");
            Console.WriteLine("--------------");
            foreach (var item in myList)
                Console.WriteLine(item.ToString());

            // Поиск элемента -1 если его нет.
            index = myList.IndexOf("Hello");
            Console.WriteLine(index);
            Console.ReadLine();
        }
    }
}
