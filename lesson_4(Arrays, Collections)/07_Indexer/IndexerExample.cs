using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    class IndexerExample
    {
        private Man[] _man;
        private int _count = 10;
        private string _first = "first";
        private string _second = "second";
        private string _default = "default ";

        public IndexerExample()
        {
            _man = new Man[_count];
            for (int i = 0; i < _count; i++)
            {
                _man[i] = Man.GetMan();
            }        
        }

        public Man this[int i]
        {
            get
            {
                return _man[i];
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public string this[string i]
        {
            get
            {
                switch (i)
                {
                    case "1":
                        return _first;
                        break;
                    case "2":
                        return _second;
                        break;

                    default:
                        return  "Sorry value not finded";
                        break;
                }
            }
        }
    }
}

