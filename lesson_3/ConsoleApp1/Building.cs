namespace lesson_3
{
    // Абстрактный класс.
    abstract class Building
    {
        // Не абстактные члены.
        public string _ownerName;// ="Василий";
        public string _ownerLastName;// ="Пупкин";

        public Building()
        {
            _ownerLastName = "Пупкин";
            _ownerName = "Василий";
        }
        // Не абстактный метод.
        public abstract int Price();

        public string GetOwner()
        {
            return string.Format("Имя владельца - {0}, Фамилия владельца - {1}", _ownerName , _ownerLastName);
        }
        public abstract int Area
        {
            get ;
           // set ;
        }
        public abstract bool LivingRoom
        {
            get;
            //set;
        }        
    }
}
