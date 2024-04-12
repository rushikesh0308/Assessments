using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments
{
    public class FindGrades
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Marks of 1st Subject:");
            int m1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Marks of 2nd Subject:");
            int m2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Marks of 3rd Subject:");
            int m3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Marks of 4th Subject:");
            int m4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Marks of 5th Subject:");
            int m5 = Convert.ToInt32(Console.ReadLine());

            double total;
            double percentage;

            total = m1 + m2 + m3 + m4 + m5;

            percentage = (total / (5 * 100)) * 100;

            if (percentage >= 75)
            {
                Console.WriteLine("Grade:First Class with Distinction");
            }
            else if (percentage >= 60 && percentage < 75)
            {
                Console.WriteLine("Grade:First Class");
            }
            else if (percentage >= 35 && percentage < 60)
            {
                Console.WriteLine("Grade:Second Class");
            }
            else if (percentage >= 0 && percentage < 35)
            {
                Console.WriteLine("Grade:Fail");
            }
        }
    }
}
