using System;

namespace _005_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleClass simpleClass = new SimpleClass();

            // Пример друго синтаксиса при создании 
            MyDelegate handler1 = simpleClass.Method1;
            MyDelegate handler2 = simpleClass.Method2;
            MyDelegate handler3 = SimpleClass.Method3;

            string result;

            MyDelegate handler4 = handler1 + handler2 + handler3;
            result =  handler4();
            Console.WriteLine($"Результат {result}");

            handler4 -= handler3;
            result = handler4();
            Console.WriteLine($"Результат {result}");

            Console.ReadLine();
        }
    }
}
