// A C# program to find the product of any two matrices. 

namespace BasicOperations
{
    class ProductTwoMatrices
    {
        public void ProductMatrix()
        {
            Console.WriteLine("Enter rows and columns of the first matrix:");
            int rows1 = int.Parse(Console.ReadLine());
            int cols1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter rows and columns of the second matrix:");
            int rows2 = int.Parse(Console.ReadLine());
            int cols2 = int.Parse(Console.ReadLine());

            // Validate matrix multiplication condition
            if (cols1 != rows2)
            {
                Console.WriteLine("Matrix multiplication is not possible. Columns of first matrix must equal rows of second.");
                return;
            }

            int[,] matrix1 = new int[rows1, cols1];
            int[,] matrix2 = new int[rows2, cols2];
            int[,] result = new int[rows1, cols2];

            // Input for matrix1
            Console.WriteLine("Enter elements of the first matrix:");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Input for matrix2
            Console.WriteLine("Enter elements of the second matrix:");
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Matrix multiplication
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            // Display result
            Console.WriteLine("\nProduct of the matrices:");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write(result[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
