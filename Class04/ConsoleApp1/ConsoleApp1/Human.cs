using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    // Vinicio - think about a class as a factory
    class Human
    {
        // Vinicio - in C#, ALL the member variables are private ALL OF THEM. EVER
        //private string name;
        //private bool hasPets;
        //private decimal yearlyIncome;
        //private string SSN;
        //private string phoneNumber;

        // Vinicio - this is a property
        private string SSN;

        // Vinicio - these do not have a body
        public string Name { get; set; }

        // Vinicio - this is called a 'backing field' and it's given to you by the compiler
        // if you don't provide a body
        private decimal _yearlyIncome;
        public decimal YearlyIncome 
        {
            get 
            { // Vinicio - body
                return _yearlyIncome;
            }

            private set 
            { 
                if(value > 0) // Vinicio - value is only allowed to be used in setters
                {
                    _yearlyIncome = value;
                }
                else
                {
                    throw new ArgumentException("ERROR - Negative income not allowed");
                }
            } 
        }

 

        public Human(string name, decimal yearlyIncome)
        {
            YearlyIncome = yearlyIncome;
            Name = name;
        }

        #region InCSharpWeNeverDoThis
        //public decimal GetYearlyIncome()
        //{
        //    return yearlyIncome;
        //}

        //public void SetYearlyIncome(decimal value)
        //{
        //    if(value > 0)
        //    {
        //        this.yearlyIncome = value;
        //    }
        //}
        #endregion


        public bool CanRentAnApartment()
        {
            // Vinicio - outside my class, I NEED to use the property, NOT THE BACKING FIELD
            if (YearlyIncome > 40000)
            {
                return true;
            }
            return false;
        }

        private void PayRent()
        {

        }
    }
}



// Add a property {get; private set}
// Add a public function
// Add a private function
// Add a property with a backing field
// Add a constructor