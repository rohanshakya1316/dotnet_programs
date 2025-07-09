using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLab
{
    // 1. Declare a delegate 
    public delegate void GreetDelegate(string name);

    class Greeter
    {
        // 2. Method that matches the delegate signature 
        public void SayHello(string name)
        {
            Console.WriteLine("Hello, " + name);
        }

        public void SayMorning(string name)
        {
            Console.WriteLine("Good Morining, " + name);
        }

    }
    class DelegateDemo
    {
        //static void Main(string[] args) 
        //{
        //    Greeter greeter = new Greeter();

        //    // 3. Create delegate instance and assign method
        //    GreetDelegate greet = greeter.SayHello;

        //    // 4. Invoke the delegate 
        //    greet.Invoke("Rohan"); 
        //    //greet("Rohan"); 

        //    // 5. Change the method the delegate points to 
        //    greet = greeter.SayMorning;
        //    greet("Reigns");    // Invoking 
        //}
    }
}
