using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.Practise
{
    public class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (isPalindrome(num))
            {
                Console.WriteLine($"{num} is Palindrome!");
            }
            else
            {
                Console.WriteLine("{0} is not Palindrome", num);
            }

        }
        static bool isPalindrome(int num)
        {
            int rev = 0;
            int temp = num;

            while (num > 0)
            {
                int rem = num % 10;
                rev = rev * 10 + rem;
                num /= 10;
            }
            return rev == temp;
        }

    }
}
