using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LoopAdditional
{
    //5.	Print Series 1  11  111  111……..n terms
    public class Que5
    {
        static void Main(string[] args)
        {
            int num = 1;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num);
                num = num * 10 + 1;
            }
        }
    }
}
