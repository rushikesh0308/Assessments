using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LoopAssignment
{
    //16.	check no is automorphic or not input n = 25 output Automorphic as 25*25=625

    public class Que16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (CheckAutomorphic(num))
                Console.WriteLine("Automorphic");
            else
                Console.WriteLine("not Automorphic");
        }
        static bool CheckAutomorphic(int num)//25
        {
            int ct=DigitCount(num);//2
            int sq = num * num;//625
           
           int rem = sq % Power(10,ct);//625%100=25
            return rem == num;//25==25
            

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
    }
}
