// A C# program to print the prime numebers from 1 to 100. 

namespace BasicOperations
{
    class PrimeNumber
    {
        public void PrintPrimeNumber()
        {
            Console.WriteLine("Prime numbers ranging from 1 to 100 are: ");
            for (int i = 2; i <= 100; i++)
            {
                bool isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write(i + " ");
                }

            }
        }
    }
}
