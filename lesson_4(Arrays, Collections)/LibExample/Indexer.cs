namespace LibExample
{
    public class Indexer : IIndexer
    {
        private Man[] _man;
        private const int _count = 10;

        public Indexer()
        {
            _man = new Man[_count];
            for (int i = 0; i < _count; i++)
            {
                _man[i] = Man.GetMan();
            }
        }
        
        // Реализация индексатора.
        public Man this[int i] => _man[i];

        public int Count => _count;
    }
}