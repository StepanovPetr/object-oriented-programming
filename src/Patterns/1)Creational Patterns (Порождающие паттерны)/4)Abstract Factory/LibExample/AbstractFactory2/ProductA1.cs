namespace LibExample.AbstractFactory2
{
    public class ProductA1 : IProductA
    {
        public string Name { get; set; }

        public ProductA1()
        {
            Name = "ProductA1";
        }
    }
}