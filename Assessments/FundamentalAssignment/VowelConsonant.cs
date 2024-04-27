using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.FundamentalAssignment
{
    public class VowelConsonant
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter character:");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U' || ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine($"{ch} is vowel");
            }
            else {
                Console.WriteLine($"{ch} is consonant");
            }
        }
    }
}
