using _003_Abstract.Enums;

namespace _003_Abstract
{
    // Абстрактный класс.
    abstract class Building : Place
    {
        // Не абстактные члены.
        public string OwnerName = "Василий";
        public string OwnerLastName = "Пупкин";

        // Не абстактный метод.
        public abstract int Price(int value);

        public override City City
        {
            get;
            set;
        }

        public string GetOwner()
        {
            return $"Имя владельца - {OwnerName}, " +
                $"Фамилия владельца - {OwnerLastName}";
        }
        public abstract int Area
        {
            get;
        }
        public abstract bool LivingRoom
        {
            get;
        }
    }
}