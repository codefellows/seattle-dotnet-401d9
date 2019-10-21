using System;
using System.Collections.Generic;
using System.Text;

namespace day05
{
    // Vinicio - If I'm inheriting from an abstract class I must provide a definition
    // for all its abstract members OR I have to be abstract myself
    class Athlete : Human, IDance
    {
        public int CaloriesPerDay { get; set; }
        public float BMI { get; set; }

        public Athlete(string name, string nickname, int age, int caloriesPerDay, float bmi) 
            : base(name, nickname, age)
        {
            BMI = bmi;
            CaloriesPerDay = caloriesPerDay;
        }

        public override void Live()
        {
            Console.WriteLine("I live for the gym! -_-");
        }

        public override void Think()
        {
            Console.WriteLine("How many more calories do I need to eat today?");
        }

        public void Dance ()
        {
            Console.WriteLine("Dancing is a sport too!");
        }
    }
}
