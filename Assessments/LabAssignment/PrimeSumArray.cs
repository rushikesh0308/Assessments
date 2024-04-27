using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LabAssignment
{
    public class PrimeSumArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int[] arr = new int[Convert.ToInt32(Console.ReadLine())];

            Console.WriteLine("Enter values:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if (CheckPrime(arr[i]))
                {
                    sum = sum + arr[i];
                }
            }
            Console.WriteLine("Sum="+sum);
        }
        static bool CheckPrime(int num)
        {
            if(num<=1)
                return false;
            else
            {
                bool flag = true;
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
