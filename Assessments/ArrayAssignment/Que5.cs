using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.ArrayAssignment
{
    public class Que5
    {
        //5.	WAP to find the maximum and minimum value in an array.
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            FindMinMax(arr);
        }
        static void FindMinMax(int[] arr)
        {
            int min = int.MaxValue;
            int max= int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Max="+max);
            Console.WriteLine("Min="+min);
        }
    }
}
