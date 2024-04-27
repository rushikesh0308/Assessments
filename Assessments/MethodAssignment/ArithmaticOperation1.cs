using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.MethodAssignment
{
    public class ArithmaticOperation1
    {
       static int a = 10, b = 5;

        public static int Add()
        {
            return a + b;
        }
        public static int Subtract()
        {
            return a - b;
        }
        public static int Multiply()
        {
            return a * b;
        }
        public static int Divide()
        {
            return a / b;
        }
        public static int Mod()
        {
            return a % b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add());
            Console.WriteLine(Subtract());
            Console.WriteLine(Multiply());
            Console.WriteLine(Divide());
            Console.WriteLine(Mod());
        }
    }
}
