using System;
using System.Collections.Generic;
using System.Text;

namespace lab07_collections
{
    class LibraryException : Exception
    {
        public Book Book { get; private set; }

        public LibraryException(Book book)
        {
            Book = book;
        }
    }
}
