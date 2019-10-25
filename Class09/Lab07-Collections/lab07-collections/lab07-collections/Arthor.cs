using System;
using System.Collections.Generic;
using System.Text;

namespace lab07_collections
{
    public class Author
    {
        public string FirstName { get; private set; }

        public string LastName { get; set; }

        public string FullName { 
            get { return FirstName + " " + LastName;}
            private set {}
        }

        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
