using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.MethodAssignment
{
    public class ArithmaticOperation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public  static int Divide(int a, int b)
        {
            return a / b;
        }
        public static int Mod(int a, int b)
        {
            return a % b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(20,10));
            Console.WriteLine(Subtract(20, 10));
            Console.WriteLine(Multiply(20, 10));
            Console.WriteLine(Divide(20, 10));
            Console.WriteLine(Mod(20, 10));
        }
    }
}
