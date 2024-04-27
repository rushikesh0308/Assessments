using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssignment
{
    //13.Write a C# program to find total number of alphabets, digits or special character in a string.
    public class Que13
    {
        static void Main(string[] args)
        {
            string s = "Hello$World123";

            CountCharacters(s);
        }
        static void CountCharacters(string s)
        {
            char[] ch = s.ToCharArray();
            int dcount = 0, scount=0, acount = 0;

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >=48 && ch[i]<=57)
                {
                    dcount++;
                }
                else if (ch[i] >=65 && ch[i]<=90 || ch[i] >=97 && ch[i]<=122)
                {
                    acount++;
                }
                else
                {
                    scount++;
                }
            }
            Console.WriteLine($"Digits={dcount}");
            Console.WriteLine($"Alphabets={acount}");
            Console.WriteLine($"Special Characters={scount}");
        }
    }
}
