using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abcdef";
            Console.WriteLine(First(s));
            Console.WriteLine();
            Console.WriteLine(Rest(s));
            Console.WriteLine();
            Console.WriteLine(Length(s));
            Console.WriteLine();
            WriteString(s);
            WriteBackward(s);
            string backwards = ReverseString("Jimmy Vu");
            Console.WriteLine(backwards);
        }
        public static char First(string s)
        {
            return s[0];
        }
        public static string Rest(string s)
        {
            return s.Substring(1);
        }
        public static int Length(string s)
        {
            return s.Length;
        }
        public static void WriteString(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
            Console.WriteLine();
        }
        public static void WriteBackward(string s)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(s[i]);
            }
            Console.WriteLine();
        }
        public static string ReverseString(string s)
        {
            string rev = new string(s.Reverse().ToArray());
            return rev;
        }
    }
}
