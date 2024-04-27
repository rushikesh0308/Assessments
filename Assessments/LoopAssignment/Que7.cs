using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LoopAssignment
{
    //7.	 Write a  program to calculate product of digits of any number.
    public class Que7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");
            int num = Convert.ToInt32(Console.ReadLine());

            int ans = 1;

            while (num > 0)
            {
                ans = ans * (num % 10);
                num /= 10;
            }
            Console.WriteLine($"Product Of Digits={ans}");
        }
    }
}
