using System;


namespace DotNetLab
{
    public class Complex
    {
        private int num1;
        private int num2;
        // public Complex() { }

        public Complex(int x, int y)
        {
            this.num1 = x; 
            this.num2 = y;
        }

        // Displaying the Numbers 
        public void DisplayNumbers()
        {
            Console.WriteLine("{0}, {1}", num1, num2);
        }

        // Overloading the + operator 
        public static Complex operator +(Complex c1, Complex c2) 
        {
            //Complex temp = new Complex(); 
            //temp.num1 = c1.num1 + c2.num1;
            //temp.num2 = c1.num2 + c2.num2;
            //return temp;

            return new Complex(c1.num1 + c2.num1, c1.num2 + c2.num2);
        }
        
    }
    class BinaryOperatorOverloading
    {
        //static void Main(string [] args)
        //{
        //    Complex c1 = new Complex(5, 10);
        //    c1.DisplayNumbers();  // displays 5 and 10

        //    Complex c2 = new Complex(15, 20);
        //    c2.DisplayNumbers();    // displays 15 and 20
            
        //    Complex c3 = c1 + c2;   
        //    c3.DisplayNumbers();    // displays 20 and 30
        //}
    }
}
