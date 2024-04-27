using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.FundamentalAssignment
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first no:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second no:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
            int choice=Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        Add(a, b);
                        break;
                    }
                case 2:
                    {
                        Sub(a, b);
                        break;
                    }
                case 3:
                    {
                        Multiply(a, b);
                        break;
                    }
                case 4:
                    {
                        Divide(a, b);
                        break;
                    }
                default:
                    Console.WriteLine("Error");
                    break;

            }
        }
        static void Add(int a, int b)
        {
            Console.WriteLine($"Ans={a+b}");
        }
        static void Sub(int a, int b)
        {
            Console.WriteLine($"Ans={a - b}");
        }
        static void Multiply(int a, int b)
        {
            Console.WriteLine($"Ans={a * b}");
        }
        static void Divide(int a, int b)
        {
            Console.WriteLine($"Ans={a / b}");
        }
    }
}
