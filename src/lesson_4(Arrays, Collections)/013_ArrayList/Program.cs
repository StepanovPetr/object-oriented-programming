using System;
using System.Collections;

namespace _013_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new ArrayList();
            string[] anArray = { "Вася", "Коля","Петя",
                "Паша", "Веня", "Яша", "Антон", "Ашот",
                "Акбар", "Дима", "Денис" };
            myList.AddRange(anArray);

            Console.WriteLine("Before sorting");
            Console.WriteLine("--------------");
            foreach (var item in myList)
                Console.Write($"{item.ToString()} ");

            myList.Sort();

            Console.WriteLine("After sorting");
            Console.WriteLine("--------------");
            foreach (var item in myList)
                Console.Write($"{item.ToString()} ");

            Console.ReadLine();
        }
    }
}
