using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "((3 + 7) * 2)";
            Exercise(a);
        }
        static void Exercise(string a)
        {
            int count = 0;
            int len = a.Length;
            for (int i = 0; i < len; i++)
            {
                if (a[i] == '(')
                {
                    count = count + 1;
                }
                else if (a[i] == ')')
                {
                    count = count - 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}
//1. The method calculates the count of parenthesis within a string by adding 1 to the count for the presence of '(' and subtracting 1 from the count for the presence of ')'
// The output is 0
//2. To generalize the statement more I turned it into a for loop to reduce code.

//string s = "((3 + 7) * 2)";
//int len = s.Length;
//int i = 0;
//int count = 0;
//while (i < len)
//{
//    char c = s[i];
//    if (c == '(')
//    {
//        count = count + 1;
//    }
//    else if (c == ')')
//    {
//        count = count - 1;
//    }
//    i = i + 1;
//}
//Console.WriteLine(count);
