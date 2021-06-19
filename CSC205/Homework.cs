using System;
namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jimmy Vu, Josiah , Ean
            Console.WriteLine("Ean, Josiah, Jimmy");
            double x1, volume;
            double a = 1.0, b = 2.83, c = 1.2;
            double r = 1.0;
            double theta = 0.523599;
            Console.WriteLine(x1 = (-b + Math.Sqrt(Math.Pow(b,2) - (4 * a * c))) /(2 * a));
            //The answer to the volume equation will be PI unless you specify the double when dividing 4/3
            Console.WriteLine(volume = (4.0 / 3.0) * Math.PI * (Math.Pow(r,3)));
            // Where you place the () really matters because it can completely change the outcome of the solution.
            Console.WriteLine(c = (Math.Pow(Math.Sin(theta),2) + (Math.Pow(Math.Cos(theta),2))));
            //Instead of creating new Console.WriteLine I can \n to create a new line.
            Console.WriteLine("  ^\n" +
                              " ^^^\n" +
                              "^^^^^");
            Console.ReadKey();
        }
    }
}
