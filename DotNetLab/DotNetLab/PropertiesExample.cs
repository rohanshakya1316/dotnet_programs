// 3. What do you mean by properties in C# explain with example.

using System;

namespace DotNetLab
{
    class PropertiesExample
    {
        // Private fields
        private string name = "Ramesh";
        private int age;

        // Public properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
                else
                    Console.WriteLine("Age cannot be negative!");
            }
        }

        public void Display()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }

        //static void Main(string[] args)
        //{
        //PropertiesExample p = new PropertiesExample();
        //    p.Name = "Rohan";  // calls set accessor
        //    p.Age = 20;        // calls set accessor

        //    p.Display();

        //    // Example of validation in setter
        //    p.Age = -5; // Will show error message

        //    Console.ReadLine();
        //}
    }

}
