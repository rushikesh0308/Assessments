using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LabAssignment
{
    public class MergeTwoArrays
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1,2,3};
            int[] arr2 = { 4,5,6};

            int[] res = new int[arr1.Length+arr2.Length];
            int index = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                res[index++] = arr1[i];
            }
            for (int i = 0;i < arr2.Length; i++)
            {
                res[index++] = arr2[i];
            }

            for(int i=0;i < res.Length; i++)
            {
                Console.Write(res[i]+" ");
            }
        }
    }
}
