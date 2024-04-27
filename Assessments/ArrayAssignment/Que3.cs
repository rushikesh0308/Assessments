using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.ArrayAssignment
{
    public class Que3
    {
        //3.	WAP to print all negative elements in an array and also count total number of negative elements in an array.
        static void Main(string[] args)
        {
            int[] arr = { -4,-3,-2,-1,0,1,2,3,4};
            PrintNegative(arr);
        }
        static void PrintNegative(int[] arr)
        {
            int ct = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine(arr[i]);
                    ct++;
                }
            }
            Console.WriteLine("Total Negative Elements="+ct);
        }
    }
}
