using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LoopAssignment
{
    //15.	check no is palimdrom or not
    public class Que15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (CheckPalindrome(num))
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("not Palindrome");
        }
        static bool CheckPalindrome(int num)
        {
            int rev = 0,temp=num;
            while (num > 0)
            {
                int rem = num % 10;
                rev = (rev * 10) + rem;
                num = num / 10;
            }
            return rev == temp;
        }
    }
}
