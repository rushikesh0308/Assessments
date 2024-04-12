using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments
{
    public class LargestBetweenThreeTernary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number:");
            int c = Convert.ToInt32(Console.ReadLine());

            int large = (a > b) ? (a > c ? a : c) : (b > c ? b : c);

            Console.WriteLine($"{large} is Greater!");
        }
    }
}
