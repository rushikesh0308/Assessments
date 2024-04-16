using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LabAssignment
{
    public class SwapNumWithTemp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first no:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second no:");
            int b = Convert.ToInt32(Console.ReadLine());

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"A:{a}  B:{b}");
        }
    }
}
