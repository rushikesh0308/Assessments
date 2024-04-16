using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LabAssignment
{
    public class MethodOverloading2
    {
        public static void Operation(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Operation(double a, double b)
        {
            Console.WriteLine(a - b);
        }
        public static void Operation(int a, int b, int c)
        {
            Console.WriteLine(a * b * c);
        }
        public static void Operation(int a, double b)
        {
            Console.WriteLine(a / b);
        }
        static void Main(string[] args)
        {
            Operation(1, 2);
        }
    }
}
