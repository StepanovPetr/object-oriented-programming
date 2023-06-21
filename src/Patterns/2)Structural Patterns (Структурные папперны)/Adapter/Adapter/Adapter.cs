// Пример адаптера уровня класса (Наследование).
namespace Adapter
{
    class Adapter : Adaptee, IDraw
    {
        public void Draw() => Paint();
    }
}
