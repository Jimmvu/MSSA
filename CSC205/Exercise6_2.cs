using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double count = 0.0;
            while (count != 1.0)
            {
                double x = .1;
                count = count + x;
                //count = Math.Round(count, 2);
                Console.Write("{0:R}", count);
                Console.ReadLine();
            }
        }
    }
}
// The reason that the function does not stop at 1.0 is because of the Round-trip fromat specifier (R) that is located in the Console.Write statement. "it attempts to ensure that a 
//numeric value is parsed back into a string... Round trips are given precedence over precision." So the precission isn't accurate hence the double .3000000004 , 7.9999, 8.999, etc. It will never be equal to 1.0.
// To solve the issue remove "{0:R}" from the Console.Write or you can round the double count beforehand.