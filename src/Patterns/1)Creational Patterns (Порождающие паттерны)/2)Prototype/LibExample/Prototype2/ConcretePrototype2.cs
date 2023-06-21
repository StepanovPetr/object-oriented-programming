namespace LibExample.Prototype2
{
    public class ConcretePrototype2 : IPrototype
    {
        public int Id { get; private set; }

        public ConcretePrototype2(int id)
        {
            Id = id;
        }
        public IPrototype Clone()
        {
            return new ConcretePrototype2(Id);
        }
    }
}