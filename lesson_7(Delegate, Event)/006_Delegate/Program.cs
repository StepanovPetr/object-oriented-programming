﻿using System;

// Анонимные (лямбда) методы.
namespace _006_Delegate
{

    // Создаем класс делегата.
    public delegate void MyDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = delegate {   Console.WriteLine("Hello world!");
                                                 Console.WriteLine("Hello world!2");
                                             };

            // Вызов анонимного метода, сообщенного с делегатом.
            myDelegate();

            // Delay.
            Console.ReadKey();
        }
    }
}
