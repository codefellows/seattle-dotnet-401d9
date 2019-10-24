using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    // Vinicio - this class is abstract ONLY because the concept is not ready to be used yet
    public abstract class MeatEater : Dinosaurs, IDestroy
    {
        public override string Name { get; set; }
        public override bool Scary { get; set; } = true;

        // Vinicio- let's remember that this breaks liskov's
        virtual public bool SharpTeeth { get; set; } = true;

        public override bool Eat()
        {
            // vinicio - this variable is not needed. Also, it's not a member variable
            //bool isEating = false;
            if (SharpTeeth == true)
            {
                //isEating = true;
                Console.WriteLine("Nom Nom. Yummy!");
                return isEating;
            }
            else
            {
                return false;
            }
        }

        public override bool Run()
        {
            try
            {
                if (Scary == true)
                {
                    Console.WriteLine(" Hurry this thing moves quick! Better move it.");
                    return true;
                }
                else
                {
                    Console.WriteLine(" It's not scary. You'll be fine.");
                    return false;
                }
            }
            //vinicio - .NET is hoping for this block to solve whatever went wrong
            catch (Exception)
            {
                // Vinicio - this code is OK for now, but it's not trynig to solve the problem
                Console.WriteLine(" Are you even scary ? ");
                return running1;
            }
        }

        public virtual bool Terrorizing()
        {
            bool terrorizing = false;
            if (Scary == true && SharpTeeth == true)
            {
                terrorizing = true;
                Console.WriteLine(" I am Terrorizing!");
                return terrorizing;
            }
            else
            {
                return terrorizing;
            }
        }

        public bool Destroy()
        {
            bool sharp = false;
            if (SharpTeeth == true)
            {
                sharp = true;
                Console.WriteLine(" Get Out Da Way!!! I'm DESTROYING things.");
                return sharp;
            }
            else
            {
                return sharp;
            }
        }
    }
}
