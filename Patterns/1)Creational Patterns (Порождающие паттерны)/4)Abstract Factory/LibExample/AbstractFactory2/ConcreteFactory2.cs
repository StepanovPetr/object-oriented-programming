namespace LibExample.AbstractFactory2
{
    public class ConcreteFactory2 : IFactory
    {
        public IProductB CreateProductB()
        {
            return new ProductB2();
        }

        public IProductA CreateProductA()
        {
            return new ProductA2();
        }
    }
}