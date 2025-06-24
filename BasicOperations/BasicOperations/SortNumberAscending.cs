// A C# program ro sort 'n' numbers in ascending order. 
namespace BasicOperations
{
    class SortNumberAscending
    {
        public void SortAscendingOrder()
        {
            int n;
            Console.WriteLine("How many numbers are there?");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.Write("Invalid input. Please enter an integer: ");
                }
            }

            // Performing Bubble Sort
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
            Console.WriteLine("Sorted in ascending order as: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]}, ");
            }
            // foreach (var number in arr)
            // {
            //     Console.Write($"{number} ");
            // }
        }
    }
}
   