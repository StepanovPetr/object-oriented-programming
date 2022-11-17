namespace LibExample.Examle.Units
{
    public class TownHall : IBuilding
    {
        public string Name => "TownHall";
        public int HitPoints { get; set; } = 1500;
        public int Gold { get; set; } = 386;
        public int Food { get; set; } = 12;
        public int Armor { get; set; } = 5;
        public int Level { get; set; } = 1;
        public int Lumber { get; set; } = 205;
    }
}
