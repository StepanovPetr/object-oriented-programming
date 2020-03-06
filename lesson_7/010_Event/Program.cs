using System;

// События.

namespace Events
{
    public delegate void EventDelegate();

    public class MyClass
    {
        public event EventDelegate HitTheWater = null;

        public void InvokeEvent()
        {
            HitTheWater.Invoke();
        }
    }

    class Program
    {
        // Методы обработчики события.

        static private void Handler1()
        {
            Console.WriteLine("Выплыть");
        }

        static private void Handler2()
        {
            Console.WriteLine("Утонуть");
        }

        static void Main()
        {
            MyClass instance = new MyClass();

            // Присоединение обработчиков событий. (Подписка на событие)
            instance.HitTheWater += new EventDelegate(Handler1);
            // instance.HitTheWater += new EventDelegate(Handler2); 

            // Метод который вызывает событие.
            instance.InvokeEvent();

            Console.WriteLine(new string('-', 20));

            // Открепляем Handler2().
            instance.HitTheWater -= new EventDelegate(Handler2);

            instance.InvokeEvent();

            // Delay.
            Console.ReadKey();
        }
    }
}
