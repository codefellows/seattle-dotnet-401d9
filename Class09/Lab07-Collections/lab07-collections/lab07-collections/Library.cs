using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab07_collections
{
    class Library<T> : IEnumerable
    {
        private T[] library = new T[5];
        private int currentIndex = 0;

        public void Add(T book)
        {
            if(currentIndex == library.Length)
            {
                Array.Resize(ref library, library.Length + 5 );
            }
            library[currentIndex] = book;
            currentIndex++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                yield return library[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
