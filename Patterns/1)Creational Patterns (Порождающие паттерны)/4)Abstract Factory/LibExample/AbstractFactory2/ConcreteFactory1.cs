namespace LibExample.AbstractFactory2
{
    public class ConcreteFactory1 : IFactory
    {
        public IProductB GreateProductB()
        {
            return new ProductB1();
        }

        public IProductA GreateProductA()
        {
            return new ProductA1();
        }
    }
}