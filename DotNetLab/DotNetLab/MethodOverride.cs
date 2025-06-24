// A C# program to demonstrate the method overriding. 
using System;

namespace DotNetLab
{
    class Mammal
    {
        // Base method marked as virtual (must be virtual to be overidden)
        public virtual void MakeSound() 
        {
            Console.WriteLine("Mammal makes a sound.");
        }
    }

    class Dog : Mammal
    {
        // Override the base method
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    class MethodOverride
    {
        //static void Main(string[] args)
        //{
        //    Mammal a = new Mammal();
        //    a.MakeSound();  // Calls base class version

        //    Dog d = new Dog();
        //    d.MakeSound();  // Calls overridden method

        //    // Polymorphism
        //    Mammal ad = new Dog();
        //    ad.MakeSound(); // Also calls overridden method

        //    Console.ReadLine();
        //}
    }
}
