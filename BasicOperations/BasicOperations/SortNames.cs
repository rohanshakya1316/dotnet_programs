// A C# program to sort 10 names in ascending order. 

namespace BasicOperations
{
    class SortNames
    {
        public void SortNameAscending()
        {
            string[] names = new string[10];

            Console.WriteLine("Enter 10 names in newlines: ");
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }

            // using Inbuilt function Sort()
            // Array.Sort(names);

            // manuall logic using bubble sorting 
            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - i - 1; j++)
                {
                    if (string.Compare(names[j], names[j + 1]) > 0)
                    {
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nNames sorted in ascending order are: ");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
