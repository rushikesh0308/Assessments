using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.ClassObject
{
    public class StudentDetails
    {
        static void Main(string[] args)
        {
            Student1 s1 = new Student1(101, "om", 89, 97, 85);
            Console.WriteLine("Total Marks Are : " + s1.TotalMarks());
            Console.WriteLine("Total Percentage Are :" + s1.CalculatePercentage());
            Console.WriteLine(s1);
        }
    }
}
