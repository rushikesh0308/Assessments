using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LabAssignment
{
    public class AreaOfCircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Radius:");
            int radius = Convert.ToInt32(Console.ReadLine());

            double pie = 3.142;
            double area = pie * radius * radius;

            Console.WriteLine($"Area of Circle is:{area}");
        }
    }
}
