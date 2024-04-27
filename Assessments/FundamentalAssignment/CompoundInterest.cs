using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.FundamentalAssignment
{
    public class CompoundInterest
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());

          
            Console.Write("Enter the rate of interest: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            
            Console.Write("Enter the number of times interest is compounded per year: ");
            int compoundFrequency = Convert.ToInt32(Console.ReadLine());

            
            Console.Write("Enter the time period in years: ");
            int time = Convert.ToInt32(Console.ReadLine());

           
            double amount = principal * Math.Pow(1 + rate / compoundFrequency, compoundFrequency * time);

            
            Console.WriteLine($"The accumulated amount, including compound interest, is: {amount}");


        }
    }
}
