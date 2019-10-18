using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    // Vinicio - if you make a class in C#, you are making a new type that has the same power
    // as any built-in type
    class Book
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public Author Author {get; set;}

        public static int Count { get; set; } = 0;

        public bool IsSigned { get; set; }

        public Book(string title, string publisher, Author author)
        {
            Title = title;
            Publisher = publisher;
            Author = author;
            IsSigned = false;
            Book.Count++;
        }
    }
}
