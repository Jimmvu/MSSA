using System;
namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour, minute, second;
            /*On top of providing hour, minute, and second, I provided variables for the equations that I will need to complete the problems.
            tpass = the percentage of the day that passed so far.
            remainder = the remainder of seconds in the day.
            s = How many seconds that has elapsed since midnight.*/
            double tpass, remainder, s;
            hour = 17;
            minute = 42;
            second = 30;
            //Instead of repeating the same equation over and over again, I designated 's' to be the equation to find the elapsed time from midnight in seconds. This way I can reuse 's' for the other equations
            s = (Math.Pow(60, 2) * hour) + (minute * 60) + second;
            remainder = ((Math.Pow(60, 2) * 24) - s);
            // tpass is the remainder of the day in percentage. It is a long decminal point percentage so I rounded up as an integer so that it is more readable.
            tpass = (int)(Math.Round(s / 86400 * 100));
            //I already tried it with the new current time and everything matches.
            Console.WriteLine($"It has been {s} seconds since midnight.");
            Console.WriteLine($"There is only {remainder} seconds left in the day.");
            Console.WriteLine($"{tpass}% of the day has passed.");
            Console.ReadKey();
        }
    }
}
