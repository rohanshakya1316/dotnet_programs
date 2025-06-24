// A C# program to demonstrate the method overloading. 
using System;

namespace DotNetLab
{
    class Calculator
    {
        // Method 1
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method 2 (Overloaded: different number of parameters)
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Method 3 (Overloaded: different type)
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    class MethodOverload
    {
        //static void Main(string[] args)
        //{
        //    Calculator calc = new Calculator();

        //    Console.WriteLine("Add(int, int): " + calc.Add(5, 10));
        //    Console.WriteLine("Add(int, int, int): " + calc.Add(1, 2, 3));
        //    Console.WriteLine("Add(double, double): " + calc.Add(2.5, 3.5));

        //    Console.ReadLine();
        //}
    }
}
