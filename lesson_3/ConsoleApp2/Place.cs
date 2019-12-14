namespace lesson_3
{
    abstract class Place
    {
        public abstract City City
        {
            get;
            set;
        }

        public abstract int Price();
    }
}
