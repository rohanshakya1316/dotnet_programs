// A C# program to demonstrate the hierarichal inheritance. 
using System;

namespace DotNetLab
{
    public class Polygon
    {
        protected int dim1, dim2;

        public void ReadDimension(int dim1, int dim2)
        {
            this.dim1 = dim1;
            this.dim2 = dim2;   
        }
    }

    public class Rectangle : Polygon
    {
        public void AreaRec()
        {
            ReadDimension(10, 6);
            int area = dim1 * dim2;
            Console.WriteLine("Area of rectangle: " + area);
        }
    }

    public class Triangle : Polygon
    {
        public void AreaTri()
        {
            ReadDimension(10, 5);
            double area = 0.5 * dim1 * dim2;
            Console.WriteLine("Area of Triangle: " + area);
        }
    }   
    class HieraricalInheritanceDemo
    {
        //static void Main(string [] args)
        //{
        //    Triangle triangle = new Triangle();
        //    triangle.AreaTri();

        //    Rectangle rectangle = new Rectangle();  
        //    rectangle.AreaRec();

        //    Console.ReadKey();
        //}
    }
}
