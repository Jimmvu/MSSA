using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter a 4 digit number");
            a = Convert.ToInt32(Console.ReadLine());
            int n1 = a / 1000 % 10;
            int n2 = a / 100 % 10;
            int n3 = a / 10 % 10;
            int n4 = a % 10;
            Console.WriteLine($"Original number: {a}.");
            /*
            Console.WriteLine($"Sum: {n1 + n2 + n3 + n4}.");
            Console.WriteLine($"In reverse order: {n4}{n3}{n2}{n1}.");

            Console.WriteLine($"Last digit first: {n4}{n1}{n2}{n3}.");
            Console.WriteLine($"Swap 2nd and 3rd digit: {n1}{n3}{n2}{n4}.");
            */
            sum(n1, n2, n3, n4);
            //Wanted to try this problem using what we learned by invoking methods
            Console.ReadKey();
        }
        static void sum(int a, int b, int c, int d)
        {
            Console.WriteLine($"Sum: {a + b + c + d}.");
            reverse(a, b, c, d);
        }
        static void reverse(int a, int b, int c, int d)
        {
            Console.WriteLine($"In reverse order: {d}{c}{b}{a}.");
            ltf(a, b, c, d);
        }
        static void ltf(int a, int b, int c, int d)
        {
            Console.WriteLine($"Last digit first: {d}{a}{b}{c}.");
            swap(a, b, c, d);
        }
        static void swap(int a, int b, int c, int d)
        {
            Console.WriteLine($"Swap 2nd and 3rd digit: {a}{c}{b}{d}.");
        }

    }
}
