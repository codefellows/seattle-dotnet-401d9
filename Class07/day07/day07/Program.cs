using System;
using System.Collections.Generic;

namespace day07
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //LinkedList list = new LinkedList();

            //list.Append(1);
            //list.Append(2);
            //list.Append(3);
            //list.Append(4);
            //list.Append(5);

            //int[] input = new int[] { 1, 2, 3, 4, 5,5,6,7,8 };

            //Console.WriteLine($"The size of the input is: {input.Length}");
            //LinearTime(input);
            //ConstantTime(input);
            //QuadraticTime(input);

            //PlayingWithEnums();

            //CustomList<string> list = new CustomList<string>();
            //list.Add("Gregor");
            //list.Add("Hound");
            //list.Add("Khaleesi");
            //list.Add("Khal Basil");

            //foreach(string current in list)
            //{
            //    Console.WriteLine(current);
            //}

            //CustomList<bool> listBool = new CustomList<bool>();
            //listBool.Add(true);
            //listBool.Add(true);
            //listBool.Add(true);
            //listBool.Add(true);
            //listBool.Add(true);

            //foreach(bool current in listBool)
            //{
            //    Console.WriteLine(current);
            //}

            //foreach (int value in PlayingWithYield())
            //{
            //    Console.WriteLine(value);
            //}

            PlayingWithCollections();

        }


        public static void PlayingWithCollections()
        {
            List<int> intList = new List<int> {1,2,3,4,5};

            LinkedList<int> intLinkedList = new LinkedList<int>();

            intLinkedList.AddLast(10);
            intLinkedList.AddLast(20);
            intLinkedList.AddLast(30);
            intLinkedList.AddLast(40);
            intLinkedList.AddLast(50);

            foreach(int current in intList)
            {
                Console.WriteLine(current);
            }

            foreach(int current in intLinkedList)
            {
                Console.WriteLine(current);
            }

            Dictionary<int, string> jsObject = new Dictionary<int, string>();
            jsObject[28] = "This is just like in Javascript AWESOME!?";
            jsObject.Add(78, "Banana");

            Console.WriteLine(jsObject[28]);
        }

        public static IEnumerable<int> PlayingWithYield()
        {
            int counter = 0;

            for(counter = 0; counter < 10; counter++)
            {
                //current = current next;
                //yield return current.data;
                yield return counter;
            }
            yield return counter;
        }

        #region Enums

        public static void PlayingWithEnums()
        {
            Date myDate = new Date();

            myDate.Month = Month.May;
            myDate.DayOfWeek = DayOfWeek.Thursday;

            Console.WriteLine(myDate.Month);
            Console.WriteLine((int) myDate.Month);

            Console.WriteLine("------------------------------");

            Console.WriteLine(myDate.DayOfWeek);
            Console.WriteLine((byte) myDate.DayOfWeek);
        }
        #endregion

        #region BigO
        static void LinearTime(int[] input)
        {
            int counter = 0;
            foreach(int value in input)
            {
                // Vinicio - pretending to work
                counter++;
            }
            Console.WriteLine($"Linear Function: {counter}");
        }
        static void ConstantTime(int[] input)
        {
            int counter = 0;
            // Vinicio - here, we have a constant that's the main factor in counting our operations
            for(int i = 0; i < 10; i++)
            {
                // Vinicio - pretending to work
                counter++;
            }
            Console.WriteLine($"Constant Function: {counter}");
        }

        static void QuadraticTime(int[] input)
        {
            int counter = 0;
            foreach(int value in input)
            {
                foreach(int innerValue in input)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Quadratic Function: {counter}");
        }
        #endregion

    }
}
