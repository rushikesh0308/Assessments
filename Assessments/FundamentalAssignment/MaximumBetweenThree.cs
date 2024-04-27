using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.FundamentalAssignment
{
    public class MaximumBetweenThree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first no:");
            int a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second no:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third no:");
            int c = Convert.ToInt32(Console.ReadLine());

            int max = (a > b) ? (a > c ? a : c) : (b > c ? b : c);
            Console.WriteLine("Maximum:" + max);
        }
    }
}
