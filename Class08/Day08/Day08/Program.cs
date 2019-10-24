using System;
using System.Linq;
using System.Collections.Generic;

namespace Day08
{
    public delegate int PerformCalculation(int x, int y);
    class Program
    {

        static int BiggerFunction(int argument)
        {
            Console.WriteLine("I'm a bigger function");
            return 20;
        }
        static void Main(string[] args)
        {
            #region introduction
            Console.WriteLine("Hello World!");

            //FunctionAsParameter((int x) => x + 1); // Vinicio - Lamba expression
            //FunctionAsParameter(BiggerFunction);


            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 8, 9, 9, 0, 8, 6, 5 };
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 6, 7 };
            LinkedList<int> intLL = new LinkedList<int>();

            var biggest = intArray.Where(x => x == intArray.Max());
            int smallest = intArray.Min();
            int sum = intArray.Sum();
            double average = intArray.Average();

            intLL.AddLast(7);

            // Vincio - Linq uses something called extension methods
            IEnumerable<int> biggerThanFive = intLL.Where((x) => x > 5).Where(x => x < 8);
            IEnumerable<int> equalToEight = intArray.Where(x => x == 8);
            // Vinicio - Query expressions
            //IEnumerable<int> query = from x in intArray where x > 5 select x;

            // Vinicio - this will enumerate the IEnumerable
            foreach (int value in biggerThanFive)
            {
                Console.WriteLine(value);
            }
            // Vinicio - some Linq methods are called finishers, and they will force enumeration
            #endregion

            Dog[] dogs =
            {
                new Dog("Khaleesi", "Kali", 2),
                new Dog("Ginger", "Ginger", 1),
                new Dog("Demi", "Demi dog", 9),
                new Dog("Gary", "Gary Bear", 6),
                new Dog("Charlotte", "Charlotte", 9),
                new Dog("Charlotte", "Charlotte", 10),
            };

            // Vinicio - JS Map
            IEnumerable<string> names = dogs.Select(x => x.Name);
            IEnumerable<int> ages = dogs.Select(x => x.Age);

            // Vinicio - This is called an annonymous type
            // Vinicio - we use var when we deal with annonymous types
            var namesAndAges = dogs.Select(x => new {x.Name, x.Age });

            IEnumerable<string> namesOlderThan5 = dogs.Where(x => x.Age > 5)
                .Select(x => x.Name)
                .OrderBy(x => x);

            IEnumerable<Dog> sortedByAge = dogs.OrderBy(x => x.Age).Reverse();

            IEnumerable<Dog> sortedByAlphabethAndAge = dogs.OrderBy(x => x.Name)
                .ThenByDescending(x => x.Age);

            IEnumerable<Dog> firstTwo = dogs.Take(2);
            IEnumerable<Dog> everythingButTheFirstTwo = dogs.Skip(2);


            string[] nameArray = new string[] { "Amanda" , "Jeff", "Cat", "Dog", "aoeu"};
            var groupedByLength = nameArray.GroupBy(x => x.Length);

            foreach(var group in groupedByLength)
            {
                // Vinicio - I know that in a groupBy. group is goung to implement IEnumerable
                // Vinicio - key is the category you are grouping by
                Console.WriteLine(group.Key);
                var isAmandaTheOnlyOne = group.SingleOrDefault(x => x == "Amanda");

                foreach(var name in group)
                {
                    Console.WriteLine(name);
                }
            }
        }

        static void FunctionAsParameter(Func<int, int> someFunction)
        {
            someFunction(50);
        }
    }
}
