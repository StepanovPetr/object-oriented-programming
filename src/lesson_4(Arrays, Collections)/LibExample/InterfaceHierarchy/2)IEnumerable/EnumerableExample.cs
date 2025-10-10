using System.Collections;
using LibExample.InterfaceHierarchy._1_IEnumerator;

namespace LibExample.InterfaceHierarchy._2_IEnumerable
{
    public class EnumerableExample : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
           return new Enumerator();
        }
    }
}