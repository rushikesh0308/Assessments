using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LoopAssignment
{
    //2. WAP to show the use of break statement ( in for loop)
    public class Que2
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
                if (i == 3)
                {
                    break;
                }
            }
        }
    }
}
