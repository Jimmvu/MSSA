using System;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringaddress = "1.1.1.1";
            Console.WriteLine(DefangIpaddr(stringaddress));

        }
        public static string DefangIpaddr(string address)
        {
            string value = "";
            foreach (var item in address)
            {
                if (item == '.')
                {
                    value+="[.]";
                }
                else
                {
                    value += item;
                }
            }
            return value;
        }
    }
}
