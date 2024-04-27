using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.FundamentalAssignment
{
    public class CelsiusToFahrenheit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in celsius:");
            double c=Convert.ToDouble(Console.ReadLine());

            double f = ((c * 9) / 5) + 32;
            Console.WriteLine($"Celsius To Fahrenheit is={f}");
        }
    }
}
