using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.FundamentalAssignment
{
    public class CalculateTotalAverage
    {
        static void Main(string[] args)
        {
            int m1, m2, m3, m4, m5;
            double total, percentage, average;
            Console.WriteLine("Enter marks of subject 1");
            m1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks of subject 2");
            m2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks of subject 3");
            m3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks of subject 4");
            m4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks of subject 5");
            m5 = Convert.ToInt32(Console.ReadLine());

            total=m1+m2+m3+m4+m5;

            average=total/5;

            percentage = (total / 500)*100;

            Console.WriteLine($"Total={total},Average={average},Percentage={percentage}");


        }
    }
}
