﻿using System;

// Комбинированные (групповые) делегаты.
namespace _003_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleClass simpleClass = new SimpleClass();

            MyDelegate handler1 = simpleClass.Method1;
            MyDelegate handler2 = simpleClass.Method2;
            MyDelegate handler3 = SimpleClass.Method3;

            MyDelegate handler4 = handler1 + handler2 + handler3;
            handler4();

            Console.ReadLine();
        }
    }
}
