using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssignment
{
    //4.	Write a C# program to trim leading white space characters in a string.
    public class Que4
    {
        static void Main(string[] args)
        {
            string s = "  Hello";

            s=s.Trim();
            Console.WriteLine($"After Trim:{s}");
        }
    }
}
