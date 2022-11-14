namespace LibExample.AbstractFactory1
{
    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductB GreateProducB()
        {
            return new ProductB2();
        }

        public override AbstractProductA GreateProductA()
        {
            return new ProductA2();
        }
    }
}