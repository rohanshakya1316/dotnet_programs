// 11.Write a C# program to create generic class and generic methods.

using System;
using System.Collections.Generic;

namespace DotNetLab
{
    // Generic Class
    public class DataStore<T>
    {
        private T data;

        public void SetData(T value)
        {
            data = value;
        }

        public T GetData()
        {
            return data;
        }
    }
    class GenericsMethods
    {
        // Generic Method
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        //public static void Main(string[] args)
        //{
        //    // Using Generic Class
        //    DataStore<int> intStore = new DataStore<int>();
        //    intStore.SetData(100);
        //    Console.WriteLine("Int Value: " + intStore.GetData());

        //    DataStore<string> stringStore = new DataStore<string>();
        //    stringStore.SetData("Rohan");
        //    Console.WriteLine("String Value: " + stringStore.GetData());

        //    // Using Generic Method
        //    int x = 5, y = 10;
        //    Console.WriteLine($"\nBefore Swap: x = {x}, y = {y}");
        //    Swap<int>(ref x, ref y);
        //    Console.WriteLine($"After Swap: x = {x}, y = {y}");

        //    string str1 = "One", str2 = "Two";
        //    Console.WriteLine($"\nBefore Swap: str1 = {str1}, str2 = {str2}");
        //    Swap<string>(ref str1, ref str2);
        //    Console.WriteLine($"After Swap: str1 = {str1}, str2 = {str2}");
        //}
    }
}
