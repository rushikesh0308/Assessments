using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LoopAssignment
{
    public class Que12
    {
        //12.	s=1!+2!+3!.........+n! find s
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num=Convert.ToInt32(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= num; i++)
            {
                sum = sum + Factorial(i);
            }
            Console.WriteLine($"Factorial sum ={sum}");

        }
        static double Factorial(int num)
        {
            double ans = 1;
            while (num > 0)
            { 
                ans *= num;
                num--;
            }
            return ans;
        }
    }
}
