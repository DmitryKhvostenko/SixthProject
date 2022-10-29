using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t62
{
    internal interface SecondClass<TKey, TValue>
    {
        public void Add(TKey key, TValue value);
        public TValue this[TKey index]
        {
            get;
        }
        public int Count { get; }
    }
}
