using System;

// https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/event
// События.
namespace Events
{
    /*
     * События представляют собой специальный вид многоадресного делегата, который можно вызвать только из класса или структуры, в которых он объявлен (класс Publisher). 
     * Если другие классы или структуры подписываются на событие, их методы обработчиков событий будут вызываться, когда класс 
     * Publisher будет вызывать событие. Дополнительные сведения и примеры кода см. в разделах События и Делегаты.
     */
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

        private static void Handler1()
        {
            Console.WriteLine("Выплыть");
        }

        private static void Handler2()
        {
            Console.WriteLine("Утонуть");
        }

        static void Main()
        {
            MyClass instance = new MyClass();

            // Присоединение обработчиков событий. (Подписка на событие)
            instance.HitTheWater += new EventDelegate(Handler1);
            //instance.HitTheWater += new EventDelegate(Handler2);


            ///instance.HitTheWater.Invoke();
            // Метод который вызывает событие.
            instance.InvokeEvent();

            Console.WriteLine(new string('-', 20));

            //// Открепляем Handler2().
            //instance.HitTheWater -= new EventDelegate(Handler2);

            //instance.InvokeEvent();

            // Delay.
            Console.ReadKey();
        }
    }
}
