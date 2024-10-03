namespace LibExample.Abstract
{
    // Конкретный класс.
    public class Flat : Building
    {
        #region Private Fields      
        private readonly int _roomCount;
        private readonly int _floor;
        private readonly int _length;
        private readonly int _width;
        #endregion

        #region Constructors
        public Flat()
        {
            _floor = 1;
            _length = 1;
            _roomCount = 1;
            _width = 1;
        }
        public Flat(int roomCount = 1, int floor = 1, int length = 1, int width = 1)
        {
            _floor = floor;
            _length = length;
            _roomCount = roomCount;
            _width = width;
        }
        #endregion

        #region Override abstract members 
        // Закомментировать для примера.
        public override int Price()
        {
            return _roomCount * _floor;
        }

        public override int Area => _roomCount * _length * _width;

        public override bool LivingRoom => true;
        #endregion
    }
}