using System;
using System.Collections.Generic;
using System.Text;

namespace day05
{
    // Vinicio - my base class is student (super class || parent class)
    // Vinicio - by convention, the class goes first, and then all the interfaces
    class CFStudent : Student, IDance
    {
        public CFStudent(string name, string nickname, int age) : base(name, nickname, age, "401-dotnet-d9")
        {

        }
        public override void Live()
        {
            Console.WriteLine("I love Salmon Cookies!");
        }

        public override void Think()
        {
            base.Think();
            Console.WriteLine("Hey. Week one and week two are tough in 401 =D");
        }

        public void Dance()
        {
            Console.WriteLine("Dancing my worries away from week1 and week 2 -o_o-");
        }
    }
}
