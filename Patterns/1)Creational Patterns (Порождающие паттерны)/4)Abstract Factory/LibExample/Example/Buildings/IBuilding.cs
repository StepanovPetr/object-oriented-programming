namespace LibExample.Examle.Units
{
    /// <summary> Основной Здание. </summary>
    public interface IBuilding
    {
        string Name { get; }

        int HitPoints { get; set;}

        int Gold { get; set; }

        int Lumber { get; set; }

        int Food { get; set; }

        int Armor { get; set;}

        int Level { get; set; }
    }
}
