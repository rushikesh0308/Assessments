using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssignment
{
    //11.Write a C# program to reverse order of words in a given string.
    public class Que11
    {
        static void Main(string[] args)
        {
            string s = "I am learning C#";

            ReverseString(s);
        }
        static void ReverseString(string s)
        {
            string[] str = s.Split(' ');

            string s1 = String.Empty;

            for (int i =str.Length-1 ; i >=0; i--)
            {
                s1=s1+ str[i]+" ";
            }
            Console.WriteLine(s1);
        }
    }
}
