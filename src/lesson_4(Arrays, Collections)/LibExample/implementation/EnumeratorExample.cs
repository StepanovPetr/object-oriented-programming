using System.Collections;
using System.Collections.Generic;

namespace LibExample.Implementation
{
    public class EnumeratorExample : IEnumerator, IEnumerable
    {
        private int _current = 0;

        private readonly List<Man> _men = new List<Man>()
        {
            Man.GetMan(),
            Man.GetMan(),
            Man.GetMan(),
            Man.GetMan(),
            Man.GetMan(),
            Man.GetMan(),
            Man.GetMan(),
            Man.GetMan(),
            Man.GetMan(),
        };
        
        public bool MoveNext()
        {
            if (_current < _men.Count -1)
            {
                _current++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _current = 0;
        }

        public object Current => _men[_current];

        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }
}