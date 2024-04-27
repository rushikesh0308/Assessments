using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LoopAssignment
{
    //11.	WAP to accept base and index from user and calculates power
    public class Que11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base:");
            int b=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter raise:");
            int r = Convert.ToInt32(Console.ReadLine());

            int ans = 1;
            for (int i = 0; i < r; i++)
            {
                ans *= b;
            }
            Console.WriteLine($"Power={ans}");
        }
    }
}
