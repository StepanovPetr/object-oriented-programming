using System;
using System.Collections;

namespace LibExample.InterfaceHierarchy._3_ICollection
{
    public class Collection : ICollection
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public int Count { get; }
        public bool IsSynchronized { get; }
        public object SyncRoot { get; }
    }
}