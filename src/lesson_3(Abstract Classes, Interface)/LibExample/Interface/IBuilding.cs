namespace LibExample.Interface
{
    // Интерфейс.
    public interface IBuilding
    {
        // Сигнатура метода.
        int Price();

        // Сигнатура свойства.
        int Area
        {
            get;
        }

        // Сигнатура свойства.
        bool LivingRoom
        {
            get;
        }
    }
}