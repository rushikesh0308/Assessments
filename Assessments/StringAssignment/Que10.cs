using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssignment
{
    //10.Write a C# program to find reverse of a string.
    public class Que10
    {
        static void Main(string[] args)
        {
            string s = "Hello World";

            char[] ch = s.ToCharArray();

            string str = String.Empty;

            for (int i = ch.Length-1;i>=0;i--)
            {
                str=str + ch[i];
            }
            Console.WriteLine($"Reverse String={str}");
        }
    }
}
