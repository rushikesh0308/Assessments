using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LabAssignment
{
    public class FindPositiveNegativeZero
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());

            string res = num > 0 ? "Positive" : num < 0 ? "Negative" : "Zero";

            Console.WriteLine(res);
        }
    }
}
