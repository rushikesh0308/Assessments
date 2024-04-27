using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.ArrayAssignment
{
    /*15.	WAP to arrange the elements of an given array of integers 
     * where all negative integers appear before all the positive integers.*/
    public class Que15
    {
        static void Main(string[] args)
        {
            int[] arr = {5,3,-1,-4,2,-2,1,-3,4 };

            for(int i=0;i<arr.Length;i++)
            {
                for(int j=arr.Length-1;j>=0;j--)
                {
                    if (arr[i]>0 && i<j)
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
