// A C# program to find sum of 20 numbers in an array.

namespace BasicOperations
{
    class ArraySumDemo
    {
        public void SumArrayElements()
        {
            int[] numbers = new int[20]; // Array to store 20 elements
            int sum = 0;

            Console.WriteLine("Enter 20 numbers:");

            // Taking input from the user
            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Element {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.Write("Invalid input. Please enter an integer: ");
                }
                sum += numbers[i]; // Adding to sum
            }

            Console.WriteLine($"\nThe sum of the 20 elements is: {sum}");
        }
    }
}
