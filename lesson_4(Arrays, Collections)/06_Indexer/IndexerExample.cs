
namespace lesson_4
{
    class IndexerExample
    {
        private Man[] _man;
        private int _count = 10;

        public IndexerExample()
        {
            _man = new Man[_count];
            for (int i = 0; i < _count; i++)
            {
                _man[i] = Man.GetMan();
            }        
        }

        public int this[int i]
        {
            get
            {
                return 6665455;
                // return _man[i];
            }
        }

        public int Count
        {
            get
            {
                return 666;
               // return _count;
            }
        }
    }
}
