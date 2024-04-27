using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssignment
{
    //6.Write a C# program to remove all occurrences of a character from string.
    public class Que6
    {
        static void Main(string[] args)
        {
            String s= "Hello World";
            char c = 'l';

            char[] ch=s.ToCharArray();

            string str = String.Empty;

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i]!=c)
                {
                    str += ch[i];
                }
            }
            Console.WriteLine($"After Removing All Occurances={str}");
        }
    }
}
