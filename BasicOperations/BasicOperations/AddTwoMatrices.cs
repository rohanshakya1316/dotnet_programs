// A C# program to add any two matrices. 

namespace BasicOperations
{
    class AddTwoMatrices
    {
        public void AddMatrix()
        {
            int row, column;
            Console.WriteLine("Enter the row size of the matrix: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the column size of the matrix: ");
            column = Convert.ToInt32(Console.ReadLine());

            // using JaggedArray
            int[][] matA = new int[row][];
            int[][] matB = new int[row][];
            int[][] sum = new int[row][];

            // initialize JaggedArray 
            for (int i = 0; i < row; i++)
            {
                matA[i] = new int[column];
                matB[i] = new int[column];
                sum[i] = new int[column];
            }
            Console.WriteLine();

            // Inputs for first matrix
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.WriteLine("Enter element of matA in position {0} {1}: ", i + 1, j + 1);
                    matA[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();

            // Elements of first matrix
            Console.WriteLine("First Matrix: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{matA[i][j]}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Inputs for second matrix
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.WriteLine("Enter element of matB in position {0} {1}: ", i + 1, j + 1);
                    matB[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine(); 

            // Elements of second matrix
            Console.WriteLine("Second Matrix: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{matB[i][j]}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Performing addition of two matrices
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    sum[i][j] = matA[i][j] + matB[i][j];
                }
            }
           
            // Sum matrix
            Console.WriteLine("Sum of Matrix: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{sum[i][j]}     ");
                }
                Console.WriteLine();
            }

        }
    }
}
