namespace LibExample
{
    public class City
    {
        public string ManInfo() => $"Название города - {this.Name} Население - {this.Population} Мэр - {this.Mayor} ";
 
        public string Name { get; set; }
        public int Population { get; set; }
        public string Mayor { get; set; }
    }
}
