using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LoopAssignment
{
    public class Que6
    {
        //6.	 Write a  program to count number of digits in any number
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");
            int num = Convert.ToInt32(Console.ReadLine());

            int ct = 0;
            while (num > 0)
            {
                ct++;
                num /= 10;
            }
            Console.WriteLine($"Digit Count={ct}");
        }
    }
}
