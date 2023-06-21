namespace LibExample.AbstractFactory1
{
    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }

        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }
    }
}