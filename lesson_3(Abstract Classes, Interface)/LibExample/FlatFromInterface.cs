using LibExample.Enums;

namespace LibExample
{
    // Конкретный класс реализующий интерфесй.
    public class FlatFromInterface : IBuilding, IPlace
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

        public FlatFromInterface()
        {
            _floor = 1;
            _length = 1;
            _roomCount = 1;
            _width = 1;
        }
        public FlatFromInterface(int roomCount = 1, int floor = 1, int length = 1, int width = 1)
        {
            _floor = floor;
            _length = length;
            _roomCount = roomCount;
            _width = width;
        }

        #endregion

        #region Interface realization
        // Закоментирвоать для примера
        public int Price()
        {
            return _roomCount * _floor;
        }

        public int Area => _roomCount * _length * _width;

        public bool LivingRoom => true;

        public City City
        {
            get;
            set;
        }   
        #endregion
    }
}