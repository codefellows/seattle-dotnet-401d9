using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Corythosaurous : MeatEater
    {
        public override string Name { get; set; }
        public override bool Scary { get; set; } = true;
        public override bool SharpTeeth { get; set; } = true;

        public override bool Eat()
        {
            bool eating1 = false;
            if (SharpTeeth == true)
            {
                eating1 = true;
                Console.WriteLine("I am Eating");
                return eating1;
            }
            else
                return
                    eating1;

        }
    }
}