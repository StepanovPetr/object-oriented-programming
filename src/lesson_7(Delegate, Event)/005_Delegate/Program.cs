using System;
using LibExample;

// Комбинированные (групповые) возвращающие значение.
namespace _005_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleClass simpleClass = new SimpleClass();

            // Предположение делегата.
            MyDelegateWithReturnValue handler1 = simpleClass.Method1WithReturnValue;
            MyDelegateWithReturnValue handler2 = simpleClass.Method2WithReturnValue;
            MyDelegateWithReturnValue handler3 = SimpleClass.Method3WithReturnValue;

            MyDelegateWithReturnValue handler4 = handler1 + handler2 + handler3;
            var result = handler4();
            Console.WriteLine($"Результат {result}");

            handler4 -= handler3;
            result = handler4();
            Console.WriteLine($"Результат {result}");

            Console.ReadLine();
        }
    }
}
