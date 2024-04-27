using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LoopAdditional
{
    //3.	Write the program  to display the first ten terms of the following series:1, 2, 4, 7, 11,

    public class Que3
    {
        static void Main(string[] args)
        {
            int num = 1;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num);
                num = num + i;
            }
        }
    }
}
