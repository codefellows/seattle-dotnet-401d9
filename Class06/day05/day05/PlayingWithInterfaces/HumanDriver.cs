using System;
using System.Collections.Generic;
using System.Text;

namespace day05.PlayingWithInterfaces
{
    class HumanDriver : IDriver
    {
        public string Model { get; set; }

        public void Drive(IDrivable drivable)
        {
            drivable.Start();
            drivable.Accelerate();
        }
    }
}
