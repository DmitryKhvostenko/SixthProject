using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t62
{
    internal interface Calc<TKey, TValue>
    {
        IEnumerator GetEnumerator();
    }
}
