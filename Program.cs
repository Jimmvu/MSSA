using System;
namespace Exercise4_2
{
    public class Buzz
    {
        public static void Baffle(string blimp)
        {
            Console.WriteLine(blimp); //5 "rattle" is the supplied parameter so it will print it out.
            Zippo("ping", -5); //6  invokes the Zippo method with the parameters ("ping",-5)
        }
        public static void Zippo(string quince, int flag)
        {
            if (flag < 0) //2,   13 is not less than 0 so this statement is skipped.
                // 7  -5 is less than 0 so it will evaluate
            {
                Console.WriteLine(quince + " zoop");//8  it will print out "ping zoop"
            }
            else
            {
                Console.WriteLine("ik"); //3 since 13 is not less than 0 the else statement is invoked and prints the line "ik"
                Baffle(quince); //4 Invokes the Baffle method using the parameters supplied by the Main method.
                Console.WriteLine("boo-wa-ha-ha"); //9 After the Baffle method is invoked, it goes back to the previous method and will print out "boo-wa-ha-ha"
            }
        }
        public static void Main(string[] args)
        {
            Zippo("rattle", 13); //1 The main entry point of the program, invokes the method 'Zippo' using the parameters ("rattle", 13)
        }
    }
}
//3. When 'Baffle' gets invoked, its parameter 'blimp' is replaced by the given parameter 'quince' which was also replaced by the parameter 'rattle' from the main entry point. So when invoked it will
// write the string "rattle".
//4. The output of the program is:
/* ik
 * rattle
 * ping zoop
 * boo-wa-ha-ha
 */