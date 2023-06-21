// Пример адаптера уровня обьекта (Композиция).
namespace Adapter2
{
    class Adapter : IDraw
    {
        private readonly Adaptee _adaptee = new Adaptee();
        public void Draw() => _adaptee.Paint();
    }

}
