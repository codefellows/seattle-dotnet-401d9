using System;
using System.Collections.Generic;
using System.Text;

namespace day05.PlayingWithInterfaces
{
    class Airplane : IDrivable, IFly
    {
        public string Model { get; set; }
        public int NumberOfPassengers { get; set; }
        public int Wingspan { get; set; }

        public void Accelerate()
        {
            Console.WriteLine("Accelerate");
        }

        public void Brake()
        {
            Console.WriteLine("Brake");
        }

        public void Start()
        {
            Console.WriteLine("Start");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }

        public void TakeOff()
        {
            Console.WriteLine("TakeOff");

        }

        public void Land()
        {
            Console.WriteLine("Land");

        }

        public void Fly()
        {
            Console.WriteLine("Fly");

        }
    }
}
