using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LoopAssignment
{
    //14.Disarum no 135=1+3*3+5*5*5=135
    public class Que14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num=Convert.ToInt32(Console.ReadLine());

            if (CheckDisarum(num))
                Console.WriteLine("Disarum");
            else
                Console.WriteLine("not Disarum");

        }
        static int DigitCount(int num)
        {
            int ct = 0;
            while (num > 0)
            { 
                ct++;
                num /= 10;
            }
            return ct;
        }
        static int Power(int b, int r)
        {
            int ans = 1;
            for (int i = 0; i < r; i++)
            {
                ans *= b;
            }
            return ans;
        }
        static bool CheckDisarum(int num)
        { 
            int ct=DigitCount(num);
            int sum = 0;
            int temp = num;

            while (num > 0)
            {
                int rem = num % 10;
                sum=sum+Power(rem, ct--);
                num /= 10;
            }
            return sum == temp;
        }
    }
    
}
