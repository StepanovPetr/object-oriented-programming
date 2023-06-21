using System;
using System.Collections;

namespace _14_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");

            // Peek() - возвращает первый элемент из очереди не удаляя его.
            object element = queue.Peek();
            Console.WriteLine(element as string); //First

            Console.WriteLine(new string('-', 10));

            if (element is string)
            {
                Console.WriteLine(queue.Dequeue()); 
            }

            // Count - возвращает количество элементов в очереди.
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            Console.ReadKey();
        }
    }
}
