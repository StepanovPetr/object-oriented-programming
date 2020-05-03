using _003_Abstract.Enums;

namespace _003_Abstract
{
    // Конкретный класс.
    class Flat : Building
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
        public Flat(int roomCount = 1, int floor = 1, int length = 1, int width = 1, City city = City.Moscow)
        {
            _floor = floor;
            _length = length;
            _roomCount = roomCount;
            _width = width;
            City = city;
        }

        public sealed override City City
        {
            get { return base.City; }
            set { base.City = value; }
        }

        public override int Price()
        {

            return _roomCount * _floor;
        }

        public override int Price(int value)
        {

            return _roomCount * _floor * value;
        }

        public override int Area => _roomCount * _length * _width;

        public override bool LivingRoom => true;
    }
}