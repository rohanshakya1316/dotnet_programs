using System;

public class ArithmeticOperatorsDemo
{
    public void arithmeticOperation()
    {
        // Default values
        int a = 25;
        int b = 5;

        // Arithmetic operations
        int sum = a + b;
        int difference = a - b;
        int product = a * b;
        int quotient = a / b;
        int remainder = a % b;

        // Display results
        Console.WriteLine("Arithmetic Operations with default values:");
        Console.WriteLine("a = " + a + ", b = " + b);
        Console.WriteLine("Sum (a + b) = " + sum);
        Console.WriteLine("Difference (a - b) = " + difference);
        Console.WriteLine("Product (a * b) = " + product);
        Console.WriteLine("Quotient (a / b) = " + quotient);
        Console.WriteLine("Remainder (a % b) = " + remainder);
    }
}

