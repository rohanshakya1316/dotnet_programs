/* A C# program to print the following pattern: 
    *
    * *
    * * *
    * * * *
    * * * * *
*/
namespace BasicOperations
{
    class StarPattern
    {
        public void PrintPattern()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*  ");
                }
                Console.WriteLine();
            }
        }
    }
}
