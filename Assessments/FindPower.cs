using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments
{
    public class FindPower
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter raise:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            long power = 1;

            for (int i = 0; i < num2; i++)
            {
                power = power * num1;
            }

            Console.WriteLine("Power is:{0}",power);
        }
    }
}
