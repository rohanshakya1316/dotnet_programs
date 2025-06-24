// 2. Write a program to implement the concept of default constructor,
// parameterized constructor and static constructor.
using System;

class ConstructorDemo
{
    // Fields
    private string name;
    private int age;
    private static string species;

    // Static constructor
    static ConstructorDemo()
    {
        species = "Human";
        Console.WriteLine("Static constructor called (once only).\n");
    }

    // Default constructor
    public ConstructorDemo()
    {
        name = "Unknown";
        age = 0;
        Console.WriteLine("Default constructor called.");
    }

    // Parameterized constructor
    public ConstructorDemo(string name, int age)
    {
        this.name = name;
        this.age = age;
        Console.WriteLine("Parameterized constructor called.");
    }

    // Display method
    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Species: " + species);
    }

    // Main method
    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Creating first object:");
    //    ConstructorDemo p1 = new ConstructorDemo(); // Calls default constructor
    //    p1.Display();

    //    Console.WriteLine("\nCreating second object:");
    //    ConstructorDemo p2 = new ConstructorDemo("Rohan", 22); // Calls parameterized constructor
    //    p2.Display();

    //    Console.ReadLine(); // Wait for user to close
    //}
}
