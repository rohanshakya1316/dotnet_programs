// 6. A C# Program to show the concept of multiple inheritance and multilevel inheritance in C#. 
using System;

namespace DotNetLab
{
    // interface for multiple inheritance 
    interface ISpecies
    {
        void Species();
    }
    // Parent Class 
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating food. ");
        }
    }

    // Child Class
    class Cat : Animal 
    {
        public void Meow()
        {
            Console.WriteLine("Cat meows. ");    
        }
    }

    // GrandChild Class
    class Kitten : Cat
    {
        public void Weep()
        {
            Console.WriteLine("Kitten weeps. ");
        }
    }

    // Class implements both interface and Animal class 
    class People : Animal, ISpecies
    {
        public void Species()
        {
            Console.WriteLine("Species is Human. ");
        }
    }
    class InheritanceDemo
    {
        //static void Main(string [] args)
        //{
        //    // For Mulit-level Inheritance
        //    Console.WriteLine("For Multi - Level Inheritance: ");
        //    Kitten kitten = new Kitten();
        //    kitten.Eat();    // from Animal
        //    kitten.Meow();  // from Cat
        //    kitten.Weep();  // from Kitten

        //    // For Multiple Inheritance
        //    Console.WriteLine("\nFor Multiple Inheritance: ");
        //    People obj = new People();
        //    obj.Species();
        //    obj.Eat();

        //    Console.ReadLine();
        //}
    }
}
