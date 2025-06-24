// A C# program to demonstrate the base keyword. 
using System;

namespace DotNetLab
{
    public class BaseClass
    {
        int num;
        public BaseClass()
        {
            Console.WriteLine("in BaseClass()");
        }
        public BaseClass(int i)
        {
            num = i;
            Console.WriteLine("in BaseClass(int i)");
        }

        public int GetNum()
        {
            return num;
        }
    }

    class DemoBaseKeyword : BaseClass
    {
        // This constructor will call BaseClass.BaseClass() 
        public DemoBaseKeyword() : base()
        {

        }

        // This constructor will call BaseClass.BaseClass(int i) 
        public DemoBaseKeyword(int i) : base(i)
        {
        }

        //static void Main(string[] args)
        //{
        //    DemoBaseKeyword md = new DemoBaseKeyword();
        //    DemoBaseKeyword md1 = new DemoBaseKeyword(5);
        //    Console.WriteLine("Number = " + md1.GetNum());
        //}
    }
}
