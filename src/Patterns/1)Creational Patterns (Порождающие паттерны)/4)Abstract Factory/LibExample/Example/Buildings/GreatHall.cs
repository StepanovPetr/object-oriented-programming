namespace LibExample.Example.Buildings
{
    public class GreatHall : IBuilding
    {
        public string Name => "GreatHall";
        public int HitPoints { get; set; } = 1500;
        public int Gold { get; set; } = 386;
        public int Food { get; set; } = 11;
        public int Armor { get; set; } = 5;
        public int Level { get; set; } = 1;
        public int Lumber { get; set; } = 185;
    }
}
