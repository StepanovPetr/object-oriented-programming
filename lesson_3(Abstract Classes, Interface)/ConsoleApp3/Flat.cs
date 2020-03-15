namespace lesson_3
{
    // Конкретный класс.
    class Flat : IBuilding
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
        }
        public Flat(int roomCount=1, int floor=1, int length=1, int width=1)
        {
            _floor = floor;
            _length = length;
            _roomCount = roomCount;
            _width = width;
        }

        public virtual int Price()
        {
            return _roomCount * _floor;
        }

        public virtual int Area
        {
            get
            {
                return _roomCount * _length *_width;
            }            
        }

        public  bool LivingRoom
        {
            get
            {
                return true;
            }
        }
     
    }
}
