using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ackerman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Ack(1,2));
        }
        public static int Ack(int m, int n)
        {
            int result;
            if (m == 0)
            {
                result = n + 1;
            }
            else if (n == 0)
            {
                result = Ack(m - 1, 1);
            }
            else
            {
                result = Ack(m - 1, Ack(m, n - 1));
            }
            return result;
        }
    }
}
