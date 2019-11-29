using System;
using System.Collections;

namespace _15_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");

            // Peek() - возвращает элемент с вершины стека, не удаляя его.
            if (stack.Peek() is string)
            {
                Console.WriteLine(stack.Pop());
            }

            // Count - возвращает количество элементов в стеке.
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
