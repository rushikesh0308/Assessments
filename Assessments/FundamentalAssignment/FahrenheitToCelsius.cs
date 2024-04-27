using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.FundamentalAssignment
{
    public class FahrenheitToCelsius
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in Fahrenheit:");
            double f = Convert.ToDouble(Console.ReadLine());

            double c = (f - 32) * 5 / 9;
            Console.WriteLine($"Celsius is={c}");
        }
    }
}
