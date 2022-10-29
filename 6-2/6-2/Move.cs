using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t62
{
    internal interface Move<TKey, TValue>
    {
        public bool MoveNext();
        public object Current();
        public void Reset();
    }
}
