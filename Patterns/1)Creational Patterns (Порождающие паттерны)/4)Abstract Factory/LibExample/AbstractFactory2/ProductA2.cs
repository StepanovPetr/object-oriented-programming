namespace LibExample.AbstractFactory2
{
    public class ProductA2 : IProductA
    {
        public string Name { get; set; }

        public ProductA2()
        {
            Name = "ProductA2";
        }
    }
}