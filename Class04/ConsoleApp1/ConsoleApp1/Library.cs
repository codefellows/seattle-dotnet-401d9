using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Library
    {
        public Book[] Books {get; private set;}

        public Library(Book[] books)
        {
            Books = books;
        }
    }
}
