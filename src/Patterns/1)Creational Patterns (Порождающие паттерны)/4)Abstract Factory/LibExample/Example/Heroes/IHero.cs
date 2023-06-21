namespace LibExample.Example.Heroes
{
    /// <summary> Основной Герой. </summary>
    public interface IHero
    {
        string Name { get; }

        int HitPoints { get; set;}

        int Gold { get; set; }

        int Food { get; set; }

        int Armor { get; set;}

        int Level { get; set; }

        int Mana { get; set; }

        int NormalAttack { get; }
    }
}
