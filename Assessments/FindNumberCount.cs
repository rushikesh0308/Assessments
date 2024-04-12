using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments
{
    public class FindNumberCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int ct = 0;
            while (num > 0)
            {
                num /= 10;
                ct++;
            }

            Console.WriteLine($"Count is:{ct}");
        }
    }
}
