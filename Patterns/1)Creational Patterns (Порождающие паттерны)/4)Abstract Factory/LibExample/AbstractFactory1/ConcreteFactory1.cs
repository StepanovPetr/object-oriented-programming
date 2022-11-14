namespace LibExample.AbstractFactory1
{
    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductB GreateProducB()
        {
            return new ProductB1();
        }

        public override AbstractProductA GreateProductA()
        {
            return new ProductA1();
        }
    }
}