using System;

namespace Class02Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyName("amanda");
        }

        /// <summary>
        /// Outputs to the console the name of the user and generates the product for all numbers in an array
        /// </summary>
        /// <param name="name">the name of the user</param>
        public static void MyName(string name)
        {
            Console.WriteLine($"My name is {name}");

            string candy = "gummy bears";

            int[] myArray = { 1, 2, 3, 4, 5, 6, 7 };
            int product = 1;

            // gets the product of all values in the array
            for (int i = 0; i < myArray.Length; i++)
            {
                product *= myArray[i];
            }
        }
    }
}
