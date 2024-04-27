using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssignment
{
    //3.Write a C# program to count occurrences of a character in given string.
    public class Que3
    {
        static void Main(string[] args)
        {
            string s = "Framework";

            char[] ch = s.ToCharArray();
            char c = 'r';
            int ct = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == c)
                {
                    ct++;
                }
            }
            Console.WriteLine($"No. of occurances of {c}={ct}");


        }
    }
}
