namespace lesson_3
{
    // Абстрактный класс.
    interface IBuilding
    {
        // Не абстактные члены.
        //public string _ownerName ="Василий";
        //public string _ownerLastName ="Пупкин";

        // Не абстактный метод.
        int Price();

        //string GetOwner()
        //{
           // return string.Format("Имя владельца - {0}, Фамилия владельца - {1}", _ownerName , _ownerLastName);
        //}
        int Area
        {
            get ;
           // set ;
        }
        bool LivingRoom
        {
            get;
            //set;
        }        
    }
}
