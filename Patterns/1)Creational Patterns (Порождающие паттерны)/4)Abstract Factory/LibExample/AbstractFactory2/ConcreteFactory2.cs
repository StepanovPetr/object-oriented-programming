namespace LibExample.AbstractFactory2
{
    public class ConcreteFactory2 : IFactory
    {
        public IProductB GreateProductB()
        {
            return new ProductB2();
        }

        public IProductA GreateProductA()
        {
            return new ProductA2();
        }
    }
}