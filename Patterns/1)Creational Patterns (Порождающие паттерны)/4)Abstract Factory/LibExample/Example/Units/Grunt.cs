using System;

namespace LibExample.Example.Units
{
    public class Grunt : IUnit
    {
        private Random _random  = new Random();

        public int HitPoints { get; set; } = 700;
        public int Gold { get; set; } = 200;
        public int Food { get; set; } = 3;
        public int Armor { get; set; } = 1;
        public int NormalAttack => _random.Next(18, 22);
        public string Name => "Grunt";
    }
}
