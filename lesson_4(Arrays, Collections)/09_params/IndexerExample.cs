namespace lesson_4
{
    class IndexerExample
    {
        private int[] _array;
        private string _firstString;
        private string _secondString;

        public IndexerExample(string firstString, string secondString ,params int[] array)
        {
            _array = array;
            _firstString = firstString;
            _secondString = secondString;

        }

        public int this[int i]
        {
            get
            {
                return _array[i];
            }
        }

            
    }
}

