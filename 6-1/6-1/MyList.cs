using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t61
{
    internal class MyList<T> : MainClass<T>
    {
        private T[] array = new T[1];
        private int count = 0;
        int pos = -1;
        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
        public int Count
        {
            get { return count; }
        }
        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < array.Length; i++)
            {
                action(array[i]);
            }
        }
        public void Add(T item)
        {
            count++;
            Array.Resize(ref this.array, count);
            pos++;
            this.array[pos] = item;
        }
    }
}
