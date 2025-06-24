// A C# program to demonstrate use of out and params modifier.

namespace BasicOperations
{
    class OutAndParamsModifiers
    {

        // Method using 'out' to return multiple values
        static void Divide(int dividend, int divisior, out int quotient, out int remainder)
        {
            quotient = dividend / divisior;
            remainder = dividend % divisior; 
        }

        // Method using 'params' to accept variable arguments
        static void SumNumbers(out int sum, params int[] numbers)
        {
            sum = 0; 
            foreach (int item in numbers)
            {
                sum += item; 
            }
        }

        //static void Main(string[] args)
        //{
        //    // Use of 'out' modifier. 
        //    int quotient, remainder;
        //    Divide(25, 3, out quotient, out remainder);

        //    Console.WriteLine($"The quotient is {quotient}, and remainder is {remainder}");

        //    // Use of 'params' modifier. 
        //    int sum;
        //    SumNumbers(out sum, 5, 10, 15, 20, 25);

        //    Console.WriteLine("The sum is {0}", sum);
        //}

        

       
        
    }
}
