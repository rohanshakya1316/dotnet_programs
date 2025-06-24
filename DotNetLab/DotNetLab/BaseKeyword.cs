// 9. Explain the use of base keyword in C# with example.

using System;

namespace DotNetLab
{
    class Animal1
    {
        // Base class field
        protected string name;

        // Base class constructor
        public Animal1(string name)
        {
            this.name = name;
            Console.WriteLine("Animal constructor called. Name: " + name);
        }

        // Base class method
        public void ShowName()
        {
            Console.WriteLine("Animal name from base: " + name);
        }

        // Virtual method to be overridden
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    class Dog1 : Animal1
    {
        // Derived class constructor calls base constructor
        public Dog1(string name) : base(name)
        {
            Console.WriteLine("Dog constructor called.");
        }

        // Overriding base method and calling base version too
        public override void MakeSound()
        {
            Console.WriteLine($"{base.name} says: Woof!");
            base.MakeSound(); // Calls the base version of MakeSound
        }

        // Custom method to show base method usage
        public void ShowDetails()
        {
            base.ShowName(); // Calls base method
        }
    }

    class BaseKeyword
    {
        //static void Main()
        //{
        //    Dog1 dog = new Dog1("Bruno");

        //    Console.WriteLine();
        //    dog.MakeSound();    // Uses base field and base method
        //    dog.ShowDetails();  // Calls base method directly

        //    Console.ReadLine();
        //}
    }
}
