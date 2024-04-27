using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.FundamentalAssignment
{
    public class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else {
                Console.WriteLine("Odd");
            }
        }
    }
}
