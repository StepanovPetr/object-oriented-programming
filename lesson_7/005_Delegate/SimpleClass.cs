using System;

namespace _005_Delegate
{
    class SimpleClass
    {
        public string DelegateMethod(string message)
        {
            return  message;
        }

        public string Method1()
        {
            Console.WriteLine("Method1");
            return "Method1";
        }

        public string Method2()
        {
            Console.WriteLine("Method2");
            return "Method2";
        }

        public static string Method3()
        {
            Console.WriteLine("Method3");
            return "Method3";
        }

    }
}
