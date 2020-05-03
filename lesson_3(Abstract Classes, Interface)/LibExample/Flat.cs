namespace LibExample
{
    // Конкретный класс.
    public class Flat : Building
    {
        #region Private Filds
        
        private readonly int _roomCount;
        private readonly int _floor;
        private readonly int _length;
        private readonly int _width;

        #endregion

        #region Public Filds

        // Не абстактные члены.
        public string _ownerName = "Василий";
        public string _ownerLastName = "Пупкин";

        #endregion

        #region Constactors

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

        #region Normal Methods
        public string GetOwner()
        {
            return $"Имя владельца - {_ownerName}, Фамилия владельца - {_ownerLastName}";
        }

        #endregion

        #region Override abstract members 
        // Закоментирвоать для примера
        public override int Price()
        {
            return _roomCount * _floor;
        }

        public override int Area => _roomCount * _length * _width;

        public override bool LivingRoom => true;
        #endregion
    }
}