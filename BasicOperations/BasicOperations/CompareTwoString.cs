// A C# program to compare any two strings.
using System; 
namespace BasicOperations
{
    class CompareTwoString
    {
        public void CompareStrings()
        {
            Console.WriteLine("Enter first string: ");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter second string: ");
            string str2 = Console.ReadLine();

            if (str1.Equals(str2))
            {
                Console.WriteLine("Given strings are same.");
            }
            else
            {
                Console.WriteLine("Given strings are not same.");
            }
        }

        public void CompareStringsUsingMethodCompare()
        {
            Console.WriteLine("Enter first string: ");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter second string: ");
            string str2 = Console.ReadLine();

            int result = string.Compare(str1, str2);

            if (result == 0)
            {
                Console.WriteLine("Strings are equal.");
            }
            else if (result < 0)
            {
                Console.WriteLine("The first string comes before the second string in lexicographical order.");
            }
            else
            {
                Console.WriteLine("The first string comes after the second string in lexicographical order.");
            }

        }
    }
}
