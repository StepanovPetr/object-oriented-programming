namespace lesson_4
{
    interface IIndexerExample
    {
        Man this[int i]
        {
            get;
        }

        string this[string i]
        {
            get;
        }
    }
}
