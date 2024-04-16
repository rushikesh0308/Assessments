using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.Practise
{
    public class SwapNumbers
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            a = a + b;//30
            b = a - b;//10
            a = a - b;//20

            Console.WriteLine($"a:{a} and b:{b}");
        }
    }
}
