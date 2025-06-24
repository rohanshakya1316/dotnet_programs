// A C# program to show the use of break, continue and return.


namespace BasicOperations
{
    class JumpingStatementDemo
    {
        //static void Main()
        //{
        //    Console.WriteLine("Demonstrating break, continue, and return in C#");

        //    // Using break
        //    Console.WriteLine("\nUsing break:");
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        if (i == 5)
        //        {
        //            Console.WriteLine();
        //            Console.WriteLine("Breaking the loop at i = " + i);
        //            break;  // Exits the loop when i == 5
        //        }
        //        Console.Write(i + " ");
        //    }

        //    // Using continue
        //    Console.WriteLine("\nUsing continue:");
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        if (i == 5)
        //        {
        //            Console.WriteLine();
        //            Console.WriteLine("Skipping i = " + i);
        //            continue;  // Skips the rest of the loop body for i == 5
        //        }
        //        Console.Write(i + " ");
        //    }
        //    Console.WriteLine();

        //    // Using return
        //    Console.WriteLine("\nUsing return:");
        //    ShowReturnExample();

        //    Console.WriteLine("This line will never be executed due to return inside the method.");
        //}

        static void ShowReturnExample()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("Returning from function at i = " + i);
                    return;  // Exits the method when i == 5
                }
                Console.Write(i + " ");
            }
        }
    }

}
