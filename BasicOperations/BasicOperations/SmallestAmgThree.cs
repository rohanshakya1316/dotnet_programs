// A C# program to find the smallest number among the given three numbers. 

namespace BasicOperations
{
    class SmallestAmgThree
    {
        public void CheckSmallest()
        {
            Console.WriteLine("First Number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Second Number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Third Number: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine($"The smallest number is {num1}. ");
            } else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine($"The smallest number is {num2}. ");
            }
            else
            {
                Console.WriteLine($"The smallest number is {num3}. ");
            }
        }


    }
}
