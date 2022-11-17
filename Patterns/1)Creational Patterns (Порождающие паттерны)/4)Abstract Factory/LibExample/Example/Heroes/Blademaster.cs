using System;

namespace LibExample.Examle.Units
{
    public class Blademaster : IHero
    {
        private Random _random  = new Random();

        public string Name => "Blademaster";
        public int HitPoints { get; set; } = 550;
        public int Gold { get; set; } = 425;
        public int Food { get; set; } = 5;
        public int Armor { get; set; } = 2;
        public int NormalAttack => _random.Next(24, 46);
        public int Level { get; set; } = 1;
        public int Mana { get; set; } = 285;
    }
}
