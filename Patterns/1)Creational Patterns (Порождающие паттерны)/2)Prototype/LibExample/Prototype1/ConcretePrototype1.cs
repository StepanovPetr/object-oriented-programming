namespace LibExample.Prototype1
{
    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(int id)
            : base(id)
        {
        }
        public override Prototype Clone()
        {
            return new ConcretePrototype1(Id);
        }
    }
}