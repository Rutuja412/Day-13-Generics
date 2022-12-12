using System;

namespace UC1Array
{
    class program
    {
        public static void toPrint(int[] inputArray)
        {
            foreach(int element in inputArray)
            {
             Console.WriteLine(element);
            }
            Console.WriteLine("--------");
        }
        public static void toPrint(double[] inputArray)
        {
            foreach(double element in inputArray)
            {
                Console.WriteLine(element); 
            }
            Console.WriteLine("-------------");
        }
        public static void toPrint(char[] inputArray)
        {
            foreach(char element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-----------");

        }
        public void Main(string[] args) 
        {
            int[] inputArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 1.2, 1.3, 1.4 };
            char[] charArray = { 'a', 'b', 'c', 'd' };

            program.toPrint(inputArray);
            program.toPrint(doubleArray);
            program.toPrint(charArray);
        }
    }
}


