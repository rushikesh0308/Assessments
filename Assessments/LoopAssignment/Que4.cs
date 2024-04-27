using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LoopAssignment
{
    //4.	 Write a  program to find sum of all even numbers between 1 to n. 
    public class Que4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");
            int num=Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Total Sum={sum}");
        }
    }
}
