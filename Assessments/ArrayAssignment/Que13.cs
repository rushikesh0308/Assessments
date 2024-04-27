using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.ArrayAssignment
{
    /*13.	Write a  program to test the equality of two arrays. 
     * Means e.g arr1[] = [12, 22, 32, 42, 52, 62] and arr2[] = [52, 22, 62, 12, 42, 32] 
     * Here both arrays are equal.*/
    public class Que13
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 12,22,32,42,52,62};

            int[] arr2 = {52,22,62,12,42,32 };

            Console.WriteLine(CheckEquality(arr1,arr2));
        }
        static bool CheckEquality(int[] arr1, int[] arr2)
        {

            arr1 = SortArray(arr1);
            arr2=SortArray(arr2);

            for(int i = 0,j=0; i < arr1.Length && j<arr2.Length; i++,j++)
            {
                    if (arr1[i]!= arr2[j])
                    {
                        return false;
                    }
                
            }
            return true;
        }
        static int[] SortArray(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
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
