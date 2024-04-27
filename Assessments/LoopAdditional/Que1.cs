using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LoopAdditional
{
    public class Que1
    {
        //1.	Write a program in  to display the first 10 terms of the following series:10, 20, 30, 40, ……..

        static void Main(string[] args)
        {
            for (int i = 10; i <= 100; i = i + 10)
            {
                Console.Write(i+" ");
            }
        }
    }
}
