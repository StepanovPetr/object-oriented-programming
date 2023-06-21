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

        public static void Method4(string param)
        {
            Console.WriteLine(param);
        }

        public string Method1WithReturnValue() => "Method1";

        public string Method2WithReturnValue() => "Method2";

        public static string Method3WithReturnValue() => "Method3";

        public static string Method4WithReturnValue(string param1, string param2, int age) => $"{param1} {param2} {age}";
    }
}
