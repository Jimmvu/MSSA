using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Exercise5_5
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine(Prod(1,4));
//        }
//        public static int Prod(int m, int n)
//        {
//            if (m == n)// 1!=4 // 1!=3 // 1!=2 // 1==1
//            {
//                return n;
//            }
//            else
//            {
//                int recurse = Prod(m, n - 1); //Prod(1,3) = 1 // Prod(1,2) // Prod(1,1)
//                int result = n * recurse; // result(1*2) = 2 // result(2*3) = 6 // result(6*4) = 24
//                return result;
//            }
//        }
//    }
//}
// The function Prod when invoked by the main function is a recursive method that calls upon itself until the first if statement is met.
// In the else statement after Prod has been invoked until the if statement is true. int result = n * recurse. When n = 2 the if statement is met.
// Since 4 !=1 Prod(m,4-1) is invoked. Since 3!=1 Prod(m, 3-1) is invoked. Since 2!=1 Prod(1,2-1) is invoked. Since that case is true, 1 is returned. It gets multiplied by 2 and the result is returned.
// the return value gets multiplied by n = 3 and so on and so on.
// In order result(1*2) = 2 // result(2*3) = 6 // result(6*4) = 24


namespace Exercise5_5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Prod(1,4,0));
        }
        public static int Prod(int m, int n, int recurse)
        {
            if (m == n)// 1!=4 // 1!=3 // 1!=2 // 1==1
            {
                return n;
            }
            else
            {
                recurse = Prod(m,n-1,0);
                return n * recurse;
            }
        }
    }
}