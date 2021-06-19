using System;

namespace Exercise7_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a word and see if it is Abcedarian");
            string a = Console.ReadLine();
            //the int value of 'A' is different from 'a' so I need to make sure that they are all the same capitalization.
            Console.WriteLine(Is(a.ToLower()));
        }
        public static bool Is(string a)
        {
            // i has to start at 1 because otherwise it will cause an out of range index exception. 
            for (int i = 1; i < a.Length; i++)
            {
                //At any point in the string if the value of i is less than the value of i-1 (the index of the range before it)
                //then it is not in alphabetical order. Again it has to be i-1 in order to work because it will cause 
                // an index out of range exception.
                if (a[i] < a[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
