using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LoopAdditional
{
    public class Pattern4
    {
        static void Main(string[] args)
        {
            for (int i = 7; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*"+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
