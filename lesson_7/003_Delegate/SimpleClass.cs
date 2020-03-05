using System;

namespace _003_Delegate
{
    class SimpleClass
    {
        public string DelegateMethod(string message)
        {
            return  message;
        }

        public void Method1()
        {
            Console.WriteLine("Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Method2");
        }

        public static void Method3()
        {
            Console.WriteLine("Method3");
        }

    }
}
