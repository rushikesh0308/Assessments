using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.FundamentalAssignment
{
    public class DaysInMonth
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter month no:");
            int n=Convert.ToInt32(Console.ReadLine());

            if (n >= 1 && n <= 12)
            {
                if (n == 1 || n == 3 || n == 5 || n == 7 || n == 8 || n == 10 || n == 12)
                {
                    Console.WriteLine("31 days");
                }
                else if (n == 2)
                {
                    Console.WriteLine("28 or 29 days");
                }
                else
                {
                    Console.WriteLine("30 days");
                }
            }
            else {
                Console.WriteLine("Enter correct month!");
            }
        }
    }
}
