namespace LibExample.Abstract
{
    // Абстрактный класс.
    public abstract class Building
    {
        #region Public Fields
        // Не абстактные члены.
        public string OwnerName = "Василий";
        public string OwnerLastName = "Пупкин";
        #endregion

        #region Normal Methods
        public string GetOwner()
        {
            return $"Имя владельца - {OwnerName}, " +
                $"Фамилия владельца - {OwnerLastName}";
        }
        #endregion

        #region Abstract Methods
        // Абстрактный метод.
        public abstract int Price();

        // Абстрактное свойство.
        public abstract int Area
        {
            get;
        }

        // Абстрактное свойство.
        public abstract bool LivingRoom
        {
            get;
        }
        #endregion
    }
}