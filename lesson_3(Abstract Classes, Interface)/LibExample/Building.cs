namespace LibExample
{
    // Абстрактный класс.
    public abstract class Building
    {
        // Абстрактный метод.
        public abstract int Price();
        
        // Абстрактное свойтво.
        public abstract int Area
        {
            get;
        }

        // Абстрактное свойтво.
        public abstract bool LivingRoom
        {
            get;
        }
    }
}