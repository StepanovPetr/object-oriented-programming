using System;

namespace LibExample.Examle.Units
{
    public class Footman : IUnit
    {
        private Random _random  = new Random();

        public int HitPoints { get; set; } = 420;
        public int Gold { get; set; } = 135;
        public int Food { get; set; } = 2;
        public int Armor { get; set; } = 2;
        public int NormalAttack => _random.Next(12, 14);
        public string Name => "Footman";
    }
}
