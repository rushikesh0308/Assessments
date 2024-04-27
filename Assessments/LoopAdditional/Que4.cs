using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LoopAdditional
{
    //4.	Print Series 2 -4 6 -8………n terms
    public class Que4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n=Convert.ToInt32(Console.ReadLine());

            int num = 2;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(num+" ");
                }
                else {
                    Console.Write(-num+" ");
                }
                num = num + 2;
            }
        }
    }
}
