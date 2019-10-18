using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vinicio - Human is a class
            // Vinicio - amanda is an instance (a.k.a object) 
            //Human amanda = new Human("Amanda", -10);

            ////Human vinicio = new Human("Vinicio", true, 0);
            //Console.WriteLine(amanda.YearlyIncome);
            //Console.WriteLine(amanda.Name);


            Author stephenKing = new Author("Stephen", "King");
            Book IT = new Book("IT", "I don't know INC", stephenKing);
            Book theGunslinger = new Book("The Gunslinger", "I don't know INC", stephenKing);

            stephenKing.SignBook(theGunslinger);

            Author finishTheBooksGeorge = new Author("George R R", "Martin");
            Book aDanceWithDragons = new Book("A Dance with Dragons", "I don't know INC", finishTheBooksGeorge);


            Library coolLibrary = new Library(new Book[] {IT, theGunslinger, aDanceWithDragons });


            Console.WriteLine(Book.Count);
        }
    }
}
