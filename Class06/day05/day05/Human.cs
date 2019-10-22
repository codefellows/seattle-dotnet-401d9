using System;
using System.Collections.Generic;
using System.Text;

namespace day05
{
    // Vinicio - an abstract class is a class that's meant to be used ONLY
    // as part of an inheritance hierarchy. It contains common functionality
    abstract class Human
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Nickname { get; set; }
        // Vinicio - abstract functions are meant to define structure, NOT specific behavior
        // Vinicio - abstract functions allow polimorphic behavior
        public Human(string name, string nickname, int age)
        {
            Name = name;
            Nickname = nickname;
            Age = age;
        }
        abstract public void Live();

        // Vinicio - virtual functions allow polimorphic behavior
        public virtual void Think()
        {
            Console.WriteLine("I'm a human and I'm thinking!");
            Console.WriteLine("------------------------------");
        }
    }
}
