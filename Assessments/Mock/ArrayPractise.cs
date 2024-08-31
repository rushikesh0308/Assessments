using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.Mock
{
    public class ArrayPractise
    {
        static void Main(string[] args)
        {
            int ct = 0;
            for(int i=0;i<=100;i++)
            {
                if(CheckPrime(i))
                {
                    ct++;
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine("Total Count:"+ct);
        }
        static bool CheckPrime(int num)
        {
            if(num<=1)
                return false;
            else
            {
                bool flag=true;
                for(int i=2;i<=num/2;i++)
                {
                    if(num%i==0)
                    {
                        flag = false;
                        break;
                    }
                }
                return flag;
            }
        }
    }
}
