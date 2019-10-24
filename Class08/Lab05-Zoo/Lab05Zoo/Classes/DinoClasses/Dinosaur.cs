using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public abstract class Dinosaur
    {
        #region Props
        public abstract string Name { get; set; }
        public abstract bool Scary { get; set; } 
        #endregion

        // Vinicio - you can replace this by void and handle errors by exceptions
        public abstract bool Eat();
        public abstract bool Run();
        // Public
        // Private Things
    }
}
