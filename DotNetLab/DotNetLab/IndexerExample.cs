// A simple example program for indexer in C#. 
using System;

namespace DotNetLab
{
    class Program
    {
        private string [] name = new string[10];

        // Indexer 
        public string this[int index]
        {
            get { return name[index]; }
            set { name[index] = value; }
        }
    }

    class IndexerExample
    {
        //static void Main(string[] args)
        //{
        //    Program obj = new Program();

        //    // Using the indexer to set values 
        //    obj[0] = "Ravi Ojha";
        //    obj[1] = "Shyam Thakur";
        //    obj[2] = "Hari Chalise";
        //    obj[3] = "Ram Patel";
        //    obj[4] = "Laxman Thakur";
        //    obj[5] = "Saman Padey";
        //    obj[6] = "Heer Ranjha";
        //    obj[7] = "Layla Majnu";
        //    obj[8] = "Kamlesh Ranjha";
        //    obj[9] = "Kamal Thakur";

        //    // Using the indexer to get values 
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"Value at index {i}: { obj[i]}");

        //    }
        //}
    }
}
