using System.Collections;

namespace LibExample.implementation
{
    public class EnumerableExample : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
           return new EnumeratorExample();
        }
    }
}