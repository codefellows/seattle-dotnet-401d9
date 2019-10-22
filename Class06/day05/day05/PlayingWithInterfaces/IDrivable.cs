using System;
using System.Collections.Generic;
using System.Text;

namespace day05.PlayingWithInterfaces
{
    interface IDrivable
    {
        void Start();
        void Stop();

        void Brake();
        void Accelerate();
    }
}
