// A C# to check whether a number is divisible by 7 but not by 13.


namespace BasicOperations
{
    class DivisibilityTest
    {
        public void DivideTest()
        {
            int num;
            Console.WriteLine("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 7 == 0 && num % 13 != 0)
            {
                int quotient = num / 7;
                Console.WriteLine("Number {0} is divided by 7 and not by 13.", num);
                Console.WriteLine("The quotient is {0} when divided by 7.", quotient);
            }
            else
            {
                int quotient = num / 13; 
                Console.WriteLine($"Number {num} is divided by 13 and not by 7. ");
                Console.WriteLine($"The quotient is {quotient} when divided by 13.");
            }

        }
    }
}
