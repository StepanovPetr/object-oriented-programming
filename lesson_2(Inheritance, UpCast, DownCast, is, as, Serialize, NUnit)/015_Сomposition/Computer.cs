namespace _015_Сomposition
{
    public class Computer
    {
        private Hdd _hdd;
        private Monitor _monitor;
        private Ram _ram;

        // Пример композоции.
        public Computer()
        {
            _hdd = new Hdd();
            _monitor = new Monitor();
            _ram = new Ram();
        }
    }
}