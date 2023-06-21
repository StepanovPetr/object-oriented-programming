namespace LibExample.FactoryMethod2
{
    public class ConcreteCreator : ICreator
    {
        public  IProduct FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }
}