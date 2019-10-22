using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace day07
{
    // Vinicio - T is called a 'generic type'
    class CustomList<T> : IEnumerable
    {
        // Vinicio - a client developer doesn't need to mess with this data
        private T[] storage = new T[3];
        private int currentIndex = 0;

        public void Add(T item)
        {
            if(currentIndex == storage.Length)
            {
                // vinicio - invariant - the array needs to be resized, I'm at the end
                Array.Resize(ref storage, storage.Length * 2);
            }
            storage[currentIndex] = item;
            currentIndex++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < currentIndex; i++)
            {
                yield return storage[i];
            }
        }

        // Vinicio - this is legacy code for C# 1.0
        // Vinicio - this is here just in case you need to interface with legacy code
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
