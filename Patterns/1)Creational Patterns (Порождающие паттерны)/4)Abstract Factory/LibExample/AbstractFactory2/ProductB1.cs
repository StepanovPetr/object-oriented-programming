namespace LibExample.AbstractFactory2
{
    public class ProductB1 : IProductB
    {
        public string Name { get; set; }

        public ProductB1()
        {
            Name = "ProductB1";
        }
    }
}