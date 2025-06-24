using System;

namespace DotNetLab
{
    public class UnaryOperator
    {
        public int Value; 
        

        public UnaryOperator(int x)
        {
            Value = x;
        }

        // Overload the ++ operator (Prefix)

        public static UnaryOperator operator ++(UnaryOperator x)
        {
            x.Value++;  // Increment the value
            return x;   // return the incremented value
        }
    }
    class UnaryOperatorOverloading
    {
        //static void Main(string [] args)
        //{
        //    UnaryOperator counter = new UnaryOperator(7);
        //    Console.WriteLine("Counter Value: " + counter.Value);   // Counter value: 7 

        //    // Using the overloaded ++ operator 
        //    ++counter; // calls the method: operator  ==(conter x)
        //    Console.WriteLine("Incremented Counter Value: " + counter.Value); // Counter Value: 8
        //}
    }
}
