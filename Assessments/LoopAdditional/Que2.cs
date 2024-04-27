using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LoopAdditional
{
    //2.	Write the program  to display the first ten terms of the following series:1, 4, 9, 16,

    public class Que2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write((i*i)+" ");
            }
        }
    }
}
