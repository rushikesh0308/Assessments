using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LoopAssignment
{
    //13.	 check no is krishnamurthi or not 153=1!+5!+3!=153

    public class Que13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num=Convert.ToInt32(Console.ReadLine());

            int temp = num;
            int sum = 0;
            while (num > 0)
            {
                int rem = num % 10;
                sum = sum + Factorial(rem);
                num /= 10;
            }
            if (sum == temp)
            {
                Console.WriteLine("Krishnamurthy");
            }
            else {
                Console.WriteLine(" not Krishnamurthy");
            }


        }
        static int Factorial(int num)
        {
            int ans = 1;
            while (num > 0)
            {
                ans *= num;
                num--;
            }
            return ans;
        }
    }
}
