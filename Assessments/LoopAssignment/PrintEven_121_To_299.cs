using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LoopAssignment
{
    //1.WAP to print even numbers from 121 to 229 using do-while loop
    public class PrintEven_121_To_299
    {
        static void Main(string[] args)
        {
            int start = 121, end = 299;

            do
            {
                if (start % 2 == 0)
                {
                    Console.WriteLine(start);
                }
                start++;
            }while (start<=end);
        }
    }
}
