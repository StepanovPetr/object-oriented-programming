namespace LibExample.Prototype2
{
    public interface IPrototype
    {
        public int Id { get;}
       
        IPrototype Clone();
    }
}