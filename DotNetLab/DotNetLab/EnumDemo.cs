// 10.Explain the Enum with the help of the program.

using System;

namespace DotNetLab
{
    enum Weekday
    {
        Sunday,     // 0
        Monday,     // 1
        Tuesday,    // 2
        Wednesday,  // 3
        Thursday,   // 4
        Friday,     // 5
        Saturday = 7    // manually assigning number
    }

    class EnumDemo
    {
        //static void Main(string[] args)
        //{
        //    // Assign an enum value
        //    Weekday today = Weekday.Monday;

        //    // Print the enum name and its underlying value
        //    Console.WriteLine("Today is: " + today);                // Output: Monday
        //    Console.WriteLine("Numeric value: " + (int)today);      // Output: 1

        //    // Loop through all enum values
        //    Console.WriteLine("\nAll days of the week:");
        //    foreach (Weekday day in Enum.GetValues(typeof(Weekday)))
        //    {
        //        Console.WriteLine($"{day} = {(int)day}");
        //    }
        //    /*
        //            Part                                Meaning
        //    Enum.GetValues(type)            Gets all values of the enum
        //    foreach (Type var in values)	Loop through each enum value
        //    (int) day                       Converts enum to its underlying number
        //    */
        //    Console.ReadLine();
        //}
    }
}
