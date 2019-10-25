using System;
using System.Collections.Generic;
using System.Linq;

namespace lab07_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayingWithNullableTypes();
            LoadBooks();
            bool menu = true;
            while (menu)
            {
                menu = UserInterface();
            }
        }

        public static Library<Book> HogwartLibrary = new Library<Book>();
        public static List<Book> BookBag = new List<Book>();
        public static Genre bookGenre = new Genre();

        static bool UserInterface()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Hogwart's Mystery Library");
            Console.WriteLine("The books here are only available to wizards not to muggles!");
            Console.WriteLine("Please select one of the options from the menu.");
            Console.WriteLine("1) View all books");
            Console.WriteLine("2) Add a book");
            Console.WriteLine("3) Borrow a book");
            Console.WriteLine("4) Return a book");
            Console.WriteLine("5) View book bag");
            Console.WriteLine("6) Exit");
            string selection = Console.ReadLine();
            try
            {
                switch (selection)
                {
                    case "1":
                        ViewAllBooks();
                        Console.ReadLine();
                        return true;

                    case "2":
                        Console.WriteLine("Please enter information below for the book you want to add into the library.");
                        Console.WriteLine("Title of the book: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("\nAuthor's first name: ");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("\nAuthor's last name: ");
                        string lastName = Console.ReadLine();
                        AddBooks(title, firstName, lastName);
                        return true;

                    case "3":
                        BorrowBooks();
                        return true;

                    case "4":
                        ReturnBooks();
                        return true;

                    case "5":
                        ViewBookBag();
                        Console.ReadLine();
                        return true;

                    case "6":
                        Console.WriteLine("Come back next time to learn more wizard tricks.");
                        Console.ReadLine();
                        return false;

                    default:
                        Console.WriteLine("Your selection is invalid.");
                        Console.ReadLine();
                        return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static void LoadBooks()
        {
            Author author1 = new Author("Rolanda", "Hooch");
            Book book1 = new Book("Flying to The Moon", author1, Genre.Motion);

            Author author2 = new Author("Albus", "Dumbledore");
            Book book2 = new Book("To Be Who? All You Need To Know About Transfiguration", author2, Genre.Transfiguration);

            Author author3 = new Author("Gilderoy", "Lockhart");
            Book book3 = new Book("Defence Against the Dark Arts", author3, Genre.DarkMagic);

            Author author4 = new Author("Quirnus", "Quirrell");
            Book book4 = new Book("Muggles and Wizards Development History", author4, Genre.MuggleStudies);

            Author author5 = new Author("Severus", "Snape");
            Book book5 = new Book("Potions: 1 Drip 2 Spells", author5, Genre.Potions);
            Book[] OriginalBooks = new Book[] { book1, book2, book3, book4, book5 };
            foreach (Book book in OriginalBooks)
            {
                HogwartLibrary.Add(book);
            }
        }

        public static void ViewAllBooks()
        {
            foreach (Book book in HogwartLibrary)
            {
                Console.WriteLine($"{book.Title} | Author: {book.Author.FirstName} {book.Author.LastName} | Genre: {book.Genre}");
            }
        }

        static void AddBooks(string title, string firstName, string lastName)
        {
            // Vinicio - aoeuaoesuhosetuh
            //Console.WriteLine("Choose a genre for the book: ");
            //foreach (Genre genreType in bookGenre)
            //{

            //}

            Author author = new Author(firstName, lastName);
            Book book = new Book(title, author, Genre.Motion);
            HogwartLibrary.Add(book);
        }

        // VInicio - don't leave commented code in production
        //public static IEnumerable<int> LoadBooks()
        //{
        //    int counter = 0;

        //    for (counter = 0; counter < 5; counter++)
        //    {
        //        yield return counter;
        //    }
        //    yield return counter;
        //}

        static string BorrowBooks()
        { 
            return "";
        }

        static string ReturnBooks()
        {
            return "";
        }

        static string ViewBookBag()
        {
            return "";
        }

        // O(N) time O(n) space
        static void test(int[] array) 
        {
            int x;
        }

        static void PlayingWithNullableTypes()
        {
            double? test;
            char? banana;
            decimal? pizza;
            string test2 = null;

            int? nullableBalance = 5;
            nullableBalance ??= 18;


            RandomFunction(nullableBalance ?? 0);
        }

        static int RandomFunction(int x)
        {
            return x + 1;
        }
    }
}
