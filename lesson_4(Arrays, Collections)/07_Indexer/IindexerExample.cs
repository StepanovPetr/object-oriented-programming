using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    interface IindexerExample
    {

        Man this[int i]
        {
            get;
        }

        string this[string i]
        {
            get;
        }

    }
}
