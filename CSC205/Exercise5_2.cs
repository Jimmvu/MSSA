using System;
namespace Exercise5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The result is " + Multadd(1, 2, 3));
            Console.WriteLine("The result of sine and cos is: " + Multadd(Math.Cos(Math.PI / 4), .5, Math.Sin(Math.PI / 4)));
            Console.WriteLine("The result of Log is: " + Multadd(1.0, Math.Log(10), Math.Log(10) + Math.Log(2)));
            yikes(2, 3, 4);
        }
        public static double Multadd(double a, double b, double c)
        {
            double result;
            result = a * b + c;
            return result;
        }
        public static void yikes(double x, double e, double d)
        {
            double a, b, c, f;
            a = x;
            b = e*(Math.Exp(-x));
            c = Math.Sqrt(1.0 - b);
            Console.WriteLine(Multadd(a, b, c));
        }
    }
}
