using System;

namespace UC_3.CheckMaxString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Max String");
            string stringOutput = MaximumNumberCheck.MaximumStringNumber("Apple", "banana", "pineapple");
            Console.WriteLine(stringOutput);
            
        }
    }
}
