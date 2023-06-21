namespace LibExample.AbstractFactory1
{
    public class ConcreteFactory1 : AbstractFactory
    {
        /// <inheritdoc> </inheritdoc> 
        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }

        /// <inheritdoc> </inheritdoc> 
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }
    }
}