using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.ArrayAssignment
{
    /*14.WAP to replace all negative value with its immediate left elements square. 
         * Means arr[] = [12, 3,-19, 29, 5, -61, 44, 7, -9] 
         * Output array will be [12, 3, 9, 29, 5, 25, 44, 7, 49].*/
    public class Que14
    {
        static void Main(string[] args)
        {
            int[] arr = { 12,3,-19,29,5,-61,44,7,-9};

            int[] res=PrintArray(arr);

            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i]+" ");
            }
        }
        static int[] PrintArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <0)
                {
                    int temp = arr[i - 1];
                    arr[i] = temp * temp;
                }
            }
            return arr;
        }
    }
}
