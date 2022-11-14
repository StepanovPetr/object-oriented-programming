namespace LibExample.AbstractFactory1
{
    /// <summary> Абстрактная фабрика. </summary>
    public abstract class AbstractFactory
    {
        /// <summary> Создание продукта А.</summary>
        /// <returns> Продукт А. </returns>
        public abstract AbstractProductA CreateProductA();

        /// <summary> Создание продукта B.</summary>
        /// <returns> Продукт B. </returns>
        public abstract AbstractProductB CreateProductB();
    }
}