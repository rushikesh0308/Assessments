using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.Practise
{
    public class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 1)
            {
                Console.WriteLine($"{num} is not prime!");
            }
            else
            {
                int ct = 0;

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ct++;
                    }
                }
                if (ct == 0)
                {
                    Console.WriteLine("{0} is prime", num);
                }
                else
                {
                    Console.WriteLine($"{num} is not prime");
                }
            }
        }
    }
}
