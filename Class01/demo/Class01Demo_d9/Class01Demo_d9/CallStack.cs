using System;
using System.Collections.Generic;
using System.Text;

namespace Class01Demo_d9
{
    class CallStack
    {
        static void MainEX(string[] args)
        {
            try
            {
                Console.WriteLine("I am in main");
                MethodA();

            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception found: {e.Message}");
            }

            Console.WriteLine("Main method is done");
        }

        static void MethodA()
        {
            try
            {
                Console.WriteLine("I am in Method A");
                MethodB();

            }
            catch (Exception)
            {
                Console.WriteLine("Caught in Method A");
                throw;
            }

            Console.WriteLine("Method A is done");
        }

        static void MethodB()
        {
            try
            {
                Console.WriteLine("I am in Method B");
                MethodC();
            }
            catch (Exception)
            {
                Console.WriteLine("Exception was caught in Method B");
                throw;
            }

            Console.WriteLine("Method B is done");
            
        }

        static void MethodC()
        {
            Console.WriteLine("I am in Method C");
            throw (new Exception("This is from Method C"));
        }


    }
}
