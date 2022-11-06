namespace LibExample
{
    /// <summary> Пример класса Singleton. </summary>
    public class SingletonSimple
    {
        private static SingletonSimple _instance;

        /// <summary> Конструктор помечен protected или private и не может быть вызван извне. </summary>
        protected SingletonSimple()
        {
        }

        /// <summary> Метод инкапсулирующий создание обьекта. </summary>
        public static SingletonSimple Instance()
        {
            // Проверка на то что обьект еше не создан.
            if (_instance == null)
            {   // Выделение памяти под новый обьект
                _instance = new SingletonSimple();
            }

            return _instance;
        }
    }
}
