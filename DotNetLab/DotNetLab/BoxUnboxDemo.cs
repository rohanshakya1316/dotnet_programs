// 2. Write a C# program to demonstrate boxing and Unboxing


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab
{
    class BoxUnboxDemo
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("==== BOXING ====");

        //    // Value type 
        //    int num = 77;

        //    // Boxing: Converting value type to object type
        //    object boxedNum = num; 

        //    Console.WriteLine($"Original int value: {num}");
        //    Console.WriteLine($"Boxed object value: {boxedNum}");

        //    Console.WriteLine("\n==== UNBOXING ====");

        //    // Unboxing: Converting object type back to value type 
        //    int unboxedNum = (int)boxedNum; 

        //    Console.WriteLine($"Unboxed int value: {unboxedNum}");

        //    // optional : check type safety 

        //    try
        //    {
        //        object obj = "Not an int";
        //        int wrongUnbox = (int)obj;  // This will throw an exception
        //    }
        //    catch (InvalidCastException e)
        //    {
        //        Console.WriteLine($"\nError Invalid unboxing attempt: {e.Message}");
        //    }
        //}
    }
}
