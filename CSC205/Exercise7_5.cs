using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            char c = 'a';
            char d = 'b';
            int e = 1;
            int f = 2;
            string g = "Hello";
            string h = "World";
            //Bool +
            //Console.WriteLine(a+b);
            //Console.WriteLine(a+c);
            //Console.WriteLine(a+e);
            Console.WriteLine(a + g); //Performs a concatenation between a bool and string

            //Char +
            Console.WriteLine(c + e);// Performs a concatenation between a char and int
            Console.WriteLine(c + g);// Performs a concatenation between a char and string
            Console.WriteLine(c + d);// performs a concatenation between a char and char

            //Int +
            Console.WriteLine(e + f);// Performs a addition between a int and int
            Console.WriteLine(e + h);// Performs a concatenation between a in and string

            //string +
            Console.WriteLine(g + h);// Performs a concatenation between a string and a string
        }
    }
}
