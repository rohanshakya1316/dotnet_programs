using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    public class LINQusingLambda
    {
        //public static void Main(string[] args)
        //{
        //    // Student Collection 
        //    IList<Student> studentList = new List<Student>()
        //    {
        //        new Student () { StudentID = 1, StudentName = "Rohan", Age = 13 },
        //        new Student () { StudentID = 2, StudentName = "Alice", Age = 21 },
        //        new Student () { StudentID = 3, StudentName = "Bob", Age = 18 },
        //        new Student () { StudentID = 4, StudentName = "Charlie", Age = 20 },
        //        new Student () { StudentID = 5, StudentName = "Darwin", Age = 15 }
        //    };

        //    // LINQ Query Method to find out teenager students 
        //    var teenAgerStudent = studentList.Where(s => s.Age > 12 && s.Age < 20);
        //    Console.WriteLine("Teen age Studnets are: ");
        //    foreach (Student std in teenAgerStudent)
        //    {
        //        Console.WriteLine(std.StudentName);
        //    }
        //}
    }
}
