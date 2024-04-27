using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LoopAssignment
{
    //10.WAP to print table of given no
    public class Que10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            { 
                Console.WriteLine($"{num} * {i} = {num*i}");
            }
        }
    }
}
