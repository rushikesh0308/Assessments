using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LoopAssignment
{
    //9.	Find all prime number between 400 to 300;
    public class Que9
    {
        static void Main(string[] args)
        {
            for (int i = 400; i >= 300; i--)
            {
                if (isPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool isPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            else {
                int ct = 0;
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ct++;
                        break;
                    }
                }
                return ct == 0;
            }
        }
    }
}
