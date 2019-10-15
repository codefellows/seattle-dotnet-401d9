// External libraries that are required for our app
using System;

// name of the library that we are coding in/creating
namespace Class01Demo_d9
{
    // Name of our current class that we are in.
    // everything in C# is class based.
    class Program
    {
        //Main method - main entry point of our console application
        // static - living on the class level. All methods in program.cs must be static.
        // void - return type (data type)
        // Main - Method Name
        // string[] args - array of strings
        static void Main(string[] args) // method signature
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(MyName("amanda"));

            //Console.WriteLine("What is your favorite number?");
            // string answer = Console.ReadLine();
            //int result = int.Parse(answer);
            //ExceptionExample();
            CatchExceptionExample();
        }

        // public is an access modifier. It's assumed private if 
        // nothing is specified
        public static string MyName(string name)
        {
            string newName = name.ToUpper();
            return newName;
        }

        public static void ExceptionExample()
        {

            string number = "twenty";
            //try block is always run, and the code within may potentially throw an exception
            try
            {
                int twenty = Convert.ToInt32(number); // Error

                string cat = "Josie";
                Console.WriteLine("I like Cats");

            }
            catch (FormatException)
            {
                // execute logic for exception here

                Console.WriteLine("You did not convert to a proper integer");

            }
        }

        public static void CatchExceptionExample()
        {
            int number = 13, denom = 0, result;
            int[] myArray = { 22, 33, 44 };
            try
            {
                  result = number / 5; // potentially get a dividebyzero exeption
                   result = myArray[number];
                Console.WriteLine("This is working");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("you can't divide by zero");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Have a nice day!");
            }

        }

    }
}
