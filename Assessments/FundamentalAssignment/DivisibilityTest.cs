using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.FundamentalAssignment
{
    public class DivisibilityTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num=Convert.ToInt32(Console.ReadLine());

            if (num % 5 == 0 && num % 11 == 0)
            {
                Console.WriteLine($"{num} is divisible by 5 and 11");
            }
        }
    }
}
