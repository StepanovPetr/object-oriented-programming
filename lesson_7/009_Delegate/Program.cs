using System;

// Лямбда выражения и лямбда операторы.

namespace Delegates
{
    public delegate int MyDelegate(int a);

    class Program
    {
        static void Main()
        {
            MyDelegate myDelegate;

            myDelegate = delegate (int x) { return x * 2; }; // Лямбда-Метод 

            myDelegate = (x) => { return x * 2; };          // Лямбда-Оператор.

            myDelegate = x => x * 2;                        // Лямбда-Выражение.

            int result = myDelegate(4);
            Console.WriteLine(result);

            // Delay.
            Console.ReadKey();
        }
    }
}
