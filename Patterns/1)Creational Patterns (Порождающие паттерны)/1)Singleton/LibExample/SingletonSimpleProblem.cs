using System.Threading;

namespace LibExample
{
    /// <summary> Пример класса Singleton. </summary>
    public class SingletonSimpleProblem
    {
        private static SingletonSimpleProblem _instance;

        /// <summary> Конструктор помечен protected или private и не может быть вызван извне. </summary>
        protected SingletonSimpleProblem()
        {
        }

        /// <summary> Метод инкапсулирующий создание обьекта. </summary>
        public static SingletonSimpleProblem Instance()
        {
            // Проверка на то что обьект еше не создан.
            if (_instance == null)
            { 
                // Эмитация долгой работы.
                Thread.Sleep(5000);
                // Выделение памяти под новый обьект
                _instance = new SingletonSimpleProblem();
            }

            return _instance;
        }
    }
}
