using System.Collections;

namespace LibExample.implementation
{
    public class Enumerator : IEnumerator
    {
        public bool MoveNext()
        {
            throw new System.NotImplementedException();
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }

        public object Current { get; }
    }
}