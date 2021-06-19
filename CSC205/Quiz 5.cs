using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is your string Doubloon? Enter a string: ");
            string str = Console.ReadLine();
            IsDoubloon(str.ToLower());
        }
        public static void IsDoubloon(string str)
        {
            //count will count the number of matches
            int count = 0;
            //i will be in the first position 0
            for (int i = 0; i < str.Length-1; i++)
            {
                //j will be the next position for comparison
                for (int j = i+1; j < str.Length; j++)
                {
                    if(str[i] == str[j])
                        count++;
                }
            }
            //the number of matches has to be equal to the length of the string/2
            if (count == (str.Length/2) && str.Length % 2 == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
