namespace Singleton
{
    class Singleton
    {
        private static Singleton _instance;

        // Конструктор помечен  protected и не может быть вызван извне.
        protected Singleton()
        {
        }
        // Метод инкапсулирующий создание обьекта.
        public static Singleton Instance()
        {
            // Проверка на то что обьект еше не создан.
            if (_instance == null)
            {   // Выделение памяти под новый обьект
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}
