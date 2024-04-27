using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LoopAdditional
{
    public class Pattern3
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int k = 6 - i - 1; k > 0; k--)
                {
                    Console.Write(" " + " ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*" + " "+" ");
                }

                Console.WriteLine();
            }
        }
    }
}
