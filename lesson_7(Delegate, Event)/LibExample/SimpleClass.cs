using System;

namespace LibExample
{
    public class SimpleClass
    {
        public string DelegateMethodWithReturnValue(string message) => message;
        
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

        public string Method1WithReturnValue() => "Method1";

        public string Method2WithReturnValue() => "Method2";

        public static string Method3WithReturnValue() => "Method3";
    }
}
