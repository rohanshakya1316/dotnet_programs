// 1. Create a simple class named Person that contains basic information like name, age, gender, etc.
// your class should contain methods for storing and displaying data.
namespace DotNetLab
{
    class Person
    {
        // Fields to store data
        private string name;
        private int age;
        private string gender;

        // Method to store data
        public void SetData(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        // Method to display data
        public void DisplayData()
        {
            Console.WriteLine("\nNow displaying the information: ");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
        }

        // Main method
        //static void Main(string[] args)
        //{
        //    Person p = new Person();
        //    Console.Write("Enter your name: ");
        //    string name = Console.ReadLine();
        //    Console.Write("Enter your age: ");
        //    int age = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Enter your gender: ");
        //    string gender = Console.ReadLine();
        //    p.SetData(name, age, gender);
        //    p.DisplayData();

        //    Console.ReadLine(); // Waits for a key press
        //}
    }

}
