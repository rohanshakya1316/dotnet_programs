// A C# program to show the use of Switch case. 

namespace BasicOperations
{
    class SwitchDemo
    {
        public void SwitchExample()
        {
            Console.WriteLine("Enter the percentage obtained: ");
            double percent = Convert.ToDouble(Console.ReadLine());

            switch(percent)
            {
                case >= 90 and < 100:
                    Console.WriteLine("Your grade is A.");
                    break;

                case >= 80 and < 90:
                    Console.WriteLine("Your grade is B.");
                    break;

                case >= 70 and < 80:
                    Console.WriteLine("Your grade is C.");
                    break;

                case >= 60 and < 70:
                    Console.WriteLine("Your grade is D.");
                    break;

                case >= 50 and < 60:
                    Console.WriteLine("Your grade is E.");
                    break;

                case >= 0 and < 50:
                    Console.WriteLine("Your grade is F.");
                    break;

                default:
                    Console.WriteLine("Invalid Percentage.");
                    break;
            }
        }
    }
}
