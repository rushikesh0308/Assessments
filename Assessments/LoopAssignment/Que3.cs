using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LoopAssignment
{
    //3.	Write a program to print all alphabets from a to z. - using  for loop
    public class Que3
    {
        static void Main(string[] args)
        {
            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                Console.Write(ch+" ");
            }
        }
    }
}
