// A C# program to show the concept of abstract methods. 
using System;

namespace DotNetLab
{
    public abstract class Shape
    {
        // Abstract method for calculating area 
        public abstract double CalcArea(); 
    }

    public class Circle : Shape
    {
        private double radius; 
        
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Implement the abstarct method 
        public override double CalcArea()
        {
            return Math.PI * radius * radius;  // Area = πr²
        }
    }
    class AbstractMethodDemo
    {
        //static void Main(string[] args)
        //{
        //    // Create a Circle object 
        //    Circle circle = new Circle(10);
        //    Console.WriteLine("Area of Circle: " + circle.CalcArea());
        //}
    }
}
