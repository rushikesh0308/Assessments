using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.Practise
{
    public class IfElseDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("You are eligible for voting!");
            }
            else
            {
                Console.WriteLine("You are not eligible for voting!");
            }
        }
    }
}
