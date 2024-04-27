using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.FundamentalAssignment
{
    public class AlphabetDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter character:");
            char ch=Convert.ToChar(Console.ReadLine());

            if (ch >= 48 && ch <= 57)
            {
                Console.WriteLine("Digit");
            }
            else if (ch >= 65 && ch <= 90)
            {
                Console.WriteLine("Alphabet");
            }
            else if (ch >= 97 && ch <= 122)
            {
                Console.WriteLine("Alphabet");
            }
            else {
                Console.WriteLine("Special character");
            }
        }
    }
}
