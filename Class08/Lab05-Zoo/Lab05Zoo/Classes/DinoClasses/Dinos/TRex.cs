using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Trex : MeatEater
    {
        public override string Name { get; set; }
        public override bool Scary { get; set; } = false;
        public override bool SharpTeeth { get; set; } = true;

    }
}
