// A C# program to find factorial of any number.

namespace BasicOperations
{
    class FactorialDemo
    {
        public void FactorialFinder()
        {
            int fact = 1; 
            Console.WriteLine("Enter non-negative integer to find the factorial: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Please enter the valid positive number. Try Again!");
                return;
            }
            for (int i = 2; i <= number; i++)
            {
                fact *= i;
            }
            Console.WriteLine("The factorial of {0} is {1}.", number, fact);
        }
    }
}
