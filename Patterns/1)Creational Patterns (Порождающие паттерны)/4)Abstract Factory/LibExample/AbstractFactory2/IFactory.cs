namespace LibExample.AbstractFactory2
{
    /// <summary> Абстрактная фабрика. </summary>
    public interface IFactory
    {
        /// <summary> Создание продукта А.</summary>
        /// <returns> Продукт А. </returns>
        IProductA CreateProductA();

        /// <summary> Создание продукта B.</summary>
        /// <returns> Продукт B. </returns>
        IProductB CreateProductB();
    }
}