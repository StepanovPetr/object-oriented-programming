namespace lesson_3
{
    // Абстрактный класс.
    /*sealed*/ abstract class Building
    {
       public abstract int Price();
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
