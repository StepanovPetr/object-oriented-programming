using LibExample.Enums;

namespace LibExample
{
    // Конкретный класс, реализующий интерфейс.
    public class FlatFromInterface : IBuilding, IPlace
    {
        #region Private Fields        
        private readonly int _roomCount;
        private readonly int _floor;
        private readonly int _length;
        private readonly int _width;
        #endregion

        #region Public Fields
        // Не абстактные члены.
        public string _ownerName = "Василий";
        public string _ownerLastName = "Пупкин";
        #endregion

        #region Constructors
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
        // Закомментировать для примера.
        public int Price() => _roomCount * _floor;
     
        public int Area => _roomCount * _length * _width;

        public bool LivingRoom => true;

        public City City { get;set; }
        #endregion
    }
}