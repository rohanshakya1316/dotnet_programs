// 4. A Program to demonstrate the indexers in C#. 
using System;

namespace DotNetLab
{
    class IndexerDemo
    {
        private int[] numbers = new int[5]; // internal array of size 5 

        // Indexer 
        public int this[int index]
        {
            get { return numbers[index]; }
            set { numbers[index] = value; } 
        }

        //static void Main(string[] args)
        //{
        //    IndexerDemo indexer = new IndexerDemo();

        //    // Using the indexer to set values 
        //    indexer[0] = 10;
        //    indexer[1] = 15;

        //    // Using the indexer to get values 
        //    Console.WriteLine("Value at index 0: " + indexer[0]);
        //    Console.WriteLine("Value at index 1: " + indexer[1]);

        //    Console.ReadLine();
            
        //}
    }


}
