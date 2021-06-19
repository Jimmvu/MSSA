using System;
namespace Exercise4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 4, c = 5, n = 2;
            CheckFermat(a, b, c, n);
        }
        public static void CheckFermat(int a, int b, int c, int n)
        {
            int an, bn, cn;
            an = (int)Math.Pow(a, n);
            bn = (int)Math.Pow(b, n);
            cn = (int)Math.Pow(c, n);
            if (n > 2 && an + bn == cn)
                Console.WriteLine("Holy Smokes, Fermat was wrong!");
            else
                Console.WriteLine("No that doesn't work.");

        }
    }
}
