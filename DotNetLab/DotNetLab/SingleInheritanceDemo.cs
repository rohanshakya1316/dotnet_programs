// A C# program to show the single inheritance. 
using System;

namespace DotNetLab
{
    public class MyClass
    {
        string name = "Rohan Shakya"; 
        int age = 22;
        public void PersonalInfo()
        {
            Console.WriteLine("Name = {0} \nAge = {1}", name, age);
        }
    }

    // Single Inheritance
    class SingleInheritanceDemo : MyClass
    {
        int eid = 100;
        double salary = 100000.5;
        string job = "Programmer";
        public void EmployeeDetails() 
        {
            Console.WriteLine($"\nEmployee ID = {eid} \nSalary = {salary} Job = {job}");  

        }

        //public static void Main()
        //{
        //    SingleInheritanceDemo emp = new SingleInheritanceDemo();    
        //    emp.PersonalInfo();
        //    emp.EmployeeDetails();
        //}
    }
}
