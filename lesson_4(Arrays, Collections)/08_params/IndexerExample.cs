namespace lesson_4
{
    class IndexerExample
    {
        private int[] _array;

        public IndexerExample(params int[] array)
        {
            _array = array;      
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

