namespace _015_Сomposition
{
    public class Computer
    {
        private Hdd _hdd;
        private Monitor _monitor;
        private Ram _ram;

        // Пример Агрегации.
        public Computer(Hdd hdd, Monitor monitor, Ram ram )
        {
            _hdd = hdd;
            _monitor = monitor;
            _ram = ram;
        }
    }
}