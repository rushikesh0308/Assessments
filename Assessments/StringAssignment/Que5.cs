using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssignment
{
    //5.Write a C# program to count total number of words in a string. 
    public class Que5
    {
        static void Main(string[] args)
        {
            string s = "I am learning C#";

            string[] str = s.Split(' ');

            Console.WriteLine($"No of words in:{s}={str.Length}");
        }
    }
}
