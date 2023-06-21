namespace LibExample.Example.Units
{
    /// <summary> Основной юнит. </summary>
    public interface IUnit
    {
        string Name { get; }

        int HitPoints { get; set;}

        int Gold { get; set; }

        int Food { get; set; }

        int Armor { get; set;}

        int NormalAttack { get; }
    }
}
