
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.ArrayAssignment
{
    /*12.	WAP to reverse the array itself, don’t print array in reverse – I want current array reverse. 
     * Means e.g. arr[] = [3, 90, 45, 29, 37, 78]
     * so your same array must be [78, 37, 29, 45, 90, 3] without using temporary array.*/
    public class Que12
    {
        static void Main(string[] args)
        {
            int[] arr = { 3,90,45,29,37,78};

            int[] res=ReverseArray(arr);

            for(int i=0;i<res.Length;i++)
            {
                Console.Write(res[i]+" ");
            }
        }
        static int[] ReverseArray(int[] arr)
        {
            int i , j = arr.Length - 1;

            for (i = 0; i < arr.Length / 2; i++,j--)
            {
                if(i<j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            return arr;
        }
    }
}
