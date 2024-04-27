using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssignment
{
    //7.Write a C# program to trim trailing white space characters in a string.
    public class Que7
    {
        static void Main(string[] args)
        {
            string s = "Hello   ";
            Console.WriteLine(s.Length);

            string str = RemoveSpace(s);
            Console.WriteLine(str);
            Console.WriteLine(str.Length);
        }
        static string RemoveSpace(string s)
        {
            s = s.TrimEnd();
            return s;
        }
    }
}
