namespace LibExample
{
    // Абстрактный класс.
    public abstract class Building
    {
        #region Public Fields
        // Не абстактные члены.
        public string _ownerName = "Василий";
        public string _ownerLastName = "Пупкин";
        #endregion

        #region Normal Methods
        public string GetOwner()
        {
            return $"Имя владельца - {_ownerName}, " +
                $"Фамилия владельца - {_ownerLastName}";
        }
        #endregion

        #region Abstract Methods
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
        #endregion
    }
}