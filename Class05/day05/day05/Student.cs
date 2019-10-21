using System;
using System.Collections.Generic;
using System.Text;

namespace day05
{
    // STUDENT IS A HUMAN
    class Student : Human
    {

        public Student(string name, string nickname,int age,string className) : base(name, nickname, age)
        {
            ClassName = className;
        }
        public string ClassName { get; set; }
        public bool IsStressed { get; set; } = true;

        // Vinicio - this function is meant to be used as a definiton for the abstract class
        public override void Live()
        {
            Console.WriteLine("I just want to take a nap!");

        }
    }
}
