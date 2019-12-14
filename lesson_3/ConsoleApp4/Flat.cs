namespace lesson_3
{
    // Конкретный класс.
    class Flat : IBuilding, IPlace
    {
        private int _roomCount;
        private int _floor;
        private int _length;
        private int _width;


        public Flat()
        {
            _floor = 1;
            _length = 1;
            _roomCount = 1;
            _width = 1;
            City = City.Moscow;
        }
        public Flat(int roomCount=1, int floor=1, int length=1, int width=1, City city= City.Moscow)
        {
            _floor = floor;
            _length = length;
            _roomCount = roomCount;
            _width = width;
            City = city;
        }

        public virtual int Price()
        {
            return _roomCount * _floor;
        }

        public virtual City City
        {
            get;
            set;
        }
        public virtual int Area
        {
            get
            {
                return _roomCount * _length *_width;
            }            
        }

        public virtual bool LivingRoom
        {
            get
            {
                return true;
            }
        }
     
    }
}
