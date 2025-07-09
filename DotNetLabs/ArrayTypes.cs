//1. Write a C# program to demonstrate the concepts of Arrays, Multidimensional Arrays and jagged Arrays.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetLabs
{
    public class ArrayTypes
    {
        static void Main(string [] args)
        {
            // Single - dimensional array
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Array Element at index {i}: {arr[i]}");
            }

            // Multi-dimensional aray (2D - Array) 
            int[,] multiArr =
            {
                {10, 20, 30},
                {40, 50, 60},
                {70, 80, 90}
            };

            for (int row = 0; row < multiArr.GetLength(0); row++)
            {
                for (int col = 0; col < multiArr.GetLength(1); col++)
                {
                    Console.Write(multiArr[row, col] + " ");
                }
                Console.WriteLine();
            }

            // Jagged array ( array of arrays) 
            int[][] jaggedArr = new int[3][];
            jaggedArr[0] = new int[] {1, 2, 3};
            jaggedArr[1] = new int[] {4};
            jaggedArr[2] = new int[] {5, 6};

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                Console.WriteLine($"Row {i}: ");
                for(j = 0; j < jaggedArr.Length; j++)
                {
                    Console.WriteLine(jaggedArr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}