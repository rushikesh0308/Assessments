using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LabAssignment
{
    public class Display1_To_50
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i}  Welcome to Pune");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i}  Pune");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i}  Welcome");
                }
                else
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}
