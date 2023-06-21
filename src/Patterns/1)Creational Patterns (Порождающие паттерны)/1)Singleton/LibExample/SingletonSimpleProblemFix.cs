using System.Threading;

namespace LibExample
{
    /// <summary> Пример класса Singleton. </summary>
    public class SingletonSimpleProblemFix
    {
        private static SingletonSimpleProblemFix _instance;
        private static object _flag = new object();

        /// <summary> Конструктор помечен protected или private и не может быть вызван извне. </summary>
        protected SingletonSimpleProblemFix()
        {
        }

        /// <summary> Метод инкапсулирующий создание обьекта. </summary>
        public static SingletonSimpleProblemFix Instance()
        {
            // Разрешает работать только одному потоку.
            lock (_flag)
            {
                // Проверка на то что обьект еше не создан.
                if (_instance == null)
                {
                    // Эмитация долгой работы.
                    Thread.Sleep(5000);
                    // Выделение памяти под новый обьект
                    _instance = new SingletonSimpleProblemFix();
                }
            }
            return _instance;
        }
    }
}
