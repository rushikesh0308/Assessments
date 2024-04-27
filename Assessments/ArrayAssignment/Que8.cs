using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.ArrayAssignment
{
    //8.	WAP to find the second smallest element in an array.
    public class Que8
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            FindSecondSmallest(arr);
        }
        static void FindSecondSmallest(int[] arr)
        {
            int min=int.MaxValue;
            int secondMin=min;

            for(int i=0; i<arr.Length; i++)
            {
                if (min > arr[i])
                {
                    secondMin = min;
                    min= arr[i];
                }else if (secondMin > arr[i])
                {
                    secondMin = arr[i];
                }
            }
            Console.WriteLine("Second Minimum="+secondMin);
        }
    }
}
