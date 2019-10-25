using System;
using System.Collections.Generic;
using System.Text;

namespace lab07_collections
{
    // Vinicio - enums are a way to define a set of related constants in a TYPE SAFE manner
    public enum Genre
    {
        Motion = 1,
        Transfiguration,
        DarkMagic,
        MuggleStudies,
        Potions
    }

    public class Book
    {
        public string Title { get; set; }

        public Author Author { get; set; }

        public Genre Genre { get; set; }

        public Book(string title, string firstName, string lastName, Genre genre)
        {


            Title = title;
            Author = new Author(firstName, lastName);
            Genre = genre;
        }
    }
}
