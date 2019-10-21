using System;

namespace day05
{
    // Vinicio - Month is a new type
    enum Month { January = 0, February, March, April};

    class Program
    {
        static void Main(string[] args)
        {

            #region OOP
            //Human amanda = new Human();
            Student jeff = new Student("Jeff", "Jeff", 1, "401-dotnet-d2");
            int x = 5;
            //StackHeap(x,jeff);

            Console.WriteLine(x);
            Console.WriteLine($"Jeff's age is: {jeff.Age}");
            Human enrique = new Student("Enrique", "Kike", 2, "401-dotnet-d9");

            //jeff.Live();

            // Vinicio - somehow .NET knows that enrique is actually a student
            // and calls the right implementation for Live 
            // POLYMORPHISM
            //enrique.Live();

            Athlete mike = new Athlete("Mike", "Mike", 5, 3000, 2);

            CFStudent karina = new CFStudent("Karina", "Karina", 1);

            //PolymorphismInAction(new Human[] { jeff, enrique, mike, karina });

            //karina.Think();

            #endregion


            #region Interfaces
            DanceParty(karina, mike);
            #endregion


            #region Enums
            int January = 1;
            int February = 2;
            Month m = Month.April;
            WorkingWithMonths(Month.April ,84884854);
            #endregion

        }

        public static void WorkingWithMonths(Month month, int userType)
        {

        }

        public static void StackHeap(int number, Student student, bool banana)
        {
            // Vinicio - I'm going to make changes to the int and to the student
            // int is a value type, so I don't have the real one. I have a copy

            number = 10000000;
            student.Age = 100000;
        }

        public static void DanceParty(IDance first, IDance second)
        {

            first.Dance();
            second.Dance();
        }


        // Here we see the Open-Closed Principle and Polimorphism in action
        public static void PolymorphismInAction(Human[] humans)
        {
            foreach(Human h in humans)
            {
                //h.Live();
                h.Think();
            }
        }
    }
}
