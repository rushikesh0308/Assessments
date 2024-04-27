using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.FundamentalAssignment
{
    public class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year:");
            int year=Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine($"{year} is leap");
            }
            else {
                Console.WriteLine($"{year} is not leap");
            }
        }
    }
}
