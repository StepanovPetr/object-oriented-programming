namespace LibExample.AbstractFactory2
{
    public class ConcreteFactory1 : IFactory
    {
        public IProductB CreateProductB()
        {
            return new ProductB1();
        }

        public IProductA CreateProductA()
        {
            return new ProductA1();
        }
    }
}