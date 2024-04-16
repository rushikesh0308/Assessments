using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.Practise
{
    public class FindNegativePositive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine($"{num} is negative");
            }
            else if (num == 0)
            {
                Console.WriteLine($"{num} is Zero");

            }
            else
            {
                Console.WriteLine("{0} is Positive", num);
            }
        }
    }
}
