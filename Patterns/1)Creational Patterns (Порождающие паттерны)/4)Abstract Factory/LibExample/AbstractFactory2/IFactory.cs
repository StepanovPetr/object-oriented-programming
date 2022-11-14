namespace LibExample.AbstractFactory2
{
    public interface IFactory
    {
        IProductA GreateProductA();

        IProductB GreateProductB();
    }
}