// A C# program to check whether a number is odd or even.

namespace BasicOperations
{
    class OddEvenChecker
    {
        public void OddEvenCheck()
        {
            Console.WriteLine("Enter any number to check odd or even: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Given number {0} is even number.", num);
            }
            else
            {
                Console.WriteLine("Given number {0} is odd number.", num);
            }

        } 
    }
}
