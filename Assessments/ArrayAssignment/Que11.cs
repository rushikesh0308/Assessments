using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.ArrayAssignment
{
    //11.	WAP sort array elements in ascending order.
    public class Que11
    {
        static void Main(string[] args)
        {
            int[] arr = {101,33,65,8,110,45,78,90,89 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int[] res=SortArray(arr);
           
                Console.WriteLine("----After Sort----");
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i]+" ");
            }
        }
        static int[] SortArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
