using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.FundamentalAssignment
{
    public class AreaOfTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base:");
            int base1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Height:");
            int height = Convert.ToInt32(Console.ReadLine());

            double area;

            area = 0.5 * base1 * height;

            Console.WriteLine("Area of Triangle is:" + area);
        }
    }
}
