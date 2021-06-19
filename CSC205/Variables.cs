using System;
namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort one = 52130;
            sbyte two = -115;
            //can also be an uint
            int three = 4825932;
            //can also be an sbyte
            byte four = 97;
            short five = -10000;
            //can also be an short
            ushort six = 20000;
            byte seven = 224;
            //can also be a int
            uint eight = 970700000;
            //can also be an byte
            sbyte nine = 112;
            sbyte ten = -44;
            int elev = -1000000;
            //can also be a short
            ushort twelve = 1990;
            //could be a long as well but since it's not negative ulong can work as well
            ulong thirt = 123456789123456789;
            Console.WriteLine($"ushort {one}, sbyte {two}, int {three}, byte {four}, short {five}, ushort {six}, byte {seven}.");
            Console.WriteLine($"uint {eight}, sbyte {nine}, sbyte {ten}, int {elev}, ushort {twelve}, ulong {thirt}.");
            Console.ReadKey();
        }
    }
}
