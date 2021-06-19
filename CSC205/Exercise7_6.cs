using System;
namespace ThinkSharp
{
    public class MysteryClass
    {
        public static string Mystery(string s)
        {
            int i = s.Length - 1;
            string total = "";
            while (i >= 0)
            {
                char ch = s[i];
                Console.WriteLine(i + " " + ch);
                total = total + ch;
                i--;
            }
            return total;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(Mystery("Allen"));
        }
    }
}
//Mystery takes a string and does a while loop of the length of i. The value i is intialized as the length of the string -1.
//It then creates a new type char ch of the index position of the string. It writes the line 
//of i plus a space plus the value of ch. Then it calculates the total by adding total which was initialized as "" + ch. i is incremented by -1 and the loop repeats until i =0.
//At the end of the while loop it also returns the total. The output writes the string in the opposite order while providing the index value of the letters. It also prints out the string in full backwards.