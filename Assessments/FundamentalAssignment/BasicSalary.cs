using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.FundamentalAssignment
{
    public class BasicSalary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter basic salary:");
            double basicSalary=Convert.ToDouble(Console.ReadLine());

            double gross, hra=0.0, da=0.0;
            if (basicSalary <= 10000)
            {
                hra = 20;
                da = 80;


            }
            else if (basicSalary <= 20000)
            {
                hra = 25;
                da = 90;
            }
            else
            {
                hra = 30;
                da = 90;
            }
            hra = (hra / 100) * basicSalary;
            da=(da/100)*basicSalary;

            gross = hra + da + basicSalary;

            Console.WriteLine("gross salary:"+gross);
        }
    }
}
