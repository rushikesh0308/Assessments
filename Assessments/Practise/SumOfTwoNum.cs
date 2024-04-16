using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.Practise
{
    public class SumOfTwoNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first no:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second no:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int ans = num1 + num2;

            Console.WriteLine($"Addition is {ans}");
        }
    }
}
