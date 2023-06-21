using _003_Abstract.Enums;

namespace _003_Abstract
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