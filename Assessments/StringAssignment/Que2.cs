using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssignment
{
    //2.	Write a C# program to find first occurrence of a character in a given string.
    public class Que2
    {
        static void Main(string[] args)
        {
            string s = "Framework";

            char[] ch=s.ToCharArray();
            char c = 'r';
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i]==c)
                {
                    Console.WriteLine($"First Occurance At index={i}");
                    break;
                }
            }
        }
    }
}
