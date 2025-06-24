// 8. Explain the abstract class and methods with example.

using System;

namespace DotNetLab
{
    abstract class MyAnimal
    {
        // Abstract method (must be overridden)
        public abstract void MakeSound();

        // Regular method (optional to use or override)
        public void Eat()
        {
            Console.WriteLine("Animal is eating...");
        }
    }

    class MyDog : MyAnimal
    {
        // Must override the abstract method
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    class MyCat : MyAnimal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows.");
        }
    }

    class AbstractMethods
    {
        //static void Main(string[] args)
        //{
        //    // MyAnimal a = new MyAnimal(); ❌ Cannot create an object of abstract class

        //    MyAnimal dog = new MyDog();
        //    MyAnimal cat = new MyCat();

        //    dog.MakeSound(); // Dog barks.
        //    dog.Eat();       // Animal is eating...

        //    cat.MakeSound(); // Cat meows.
        //    cat.Eat();       // Animal is eating...

        //    Console.ReadLine();
        //}
    }
}
