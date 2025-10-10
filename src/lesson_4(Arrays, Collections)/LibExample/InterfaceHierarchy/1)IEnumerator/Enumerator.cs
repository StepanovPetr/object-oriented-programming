using System.Collections;

namespace LibExample.InterfaceHierarchy._1_IEnumerator
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