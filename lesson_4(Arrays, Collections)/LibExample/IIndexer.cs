namespace LibExample
{
    public interface IIndexer
    {
        // Индексатор.
        Man this[int i] { get; }
    }
}