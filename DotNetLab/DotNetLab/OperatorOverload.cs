// 5. A program to implement the concept of operator (+) overloading (Binary)
using System;

namespace DotNetLab
{
    class Point
    {
        public int X {  get; set; } 
        public int Y { get; set; }

        // Constructor 
        public Point(int x, int y)
        {
            X = x;  
            Y = y;
        }

        // Overload + operator 
        public static Point operator +(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }

        // Method to display the point 
        public void Display()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }
    }
    class OperatorOverload
    {
        //static void Main(string [] args)
        //{
        //    Point p1 = new Point(10, 20);
        //    Point p2 = new Point(30, 40);

        //    // Use overloaded + operator 
        //    Point p3 = p1 + p2;

        //    Console.WriteLine("Result of p1 + p2: "); 
        //    p3.Display();

        //    Console.ReadLine();
        //}
    }
}
