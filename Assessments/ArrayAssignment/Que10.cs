using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.ArrayAssignment
{
    //10.	WAP to merge 2 arrays to 3rd array. 3rd array should not have elements of same value.
    public class Que10
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = {10,20,30};

            int[] res=MergeArrays(a, b);

            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i]+" ");
            }
        }
        static int[] MergeArrays(int[] a, int[] b)
        {
            int[] res= new int[a.Length+b.Length];
            int index = 0;

            for(int i = 0; i < a.Length; i++)
            {
                res[index++] = a[i];
            }
            for(int i = 0;i< b.Length; i++)
            {
                res[index++] = b[i];
            }
            return res;
        }
    }
}
