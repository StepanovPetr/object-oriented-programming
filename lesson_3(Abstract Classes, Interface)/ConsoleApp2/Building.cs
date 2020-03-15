namespace lesson_3
{
    // Абстрактный класс.
    abstract class Building : Place
    {
        // Не абстактные члены.
        public string _ownerName ="Василий";
        public string _ownerLastName ="Пупкин";

        // Не абстактный метод.

        public abstract int Price( int Value);

        public override City City
        {
            get;
            set;
        }


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
