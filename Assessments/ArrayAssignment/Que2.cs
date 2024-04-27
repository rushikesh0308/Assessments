using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.ArrayAssignment
{
    /*2.	Write two methods that return the average of an array with following headers.
i.	public static int average(int[] array)
ii.	public static double average(double[] array).
iii.	Write main and invoke the 2 methods.
*/
    public class Que2
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3,4,5 };
            Console.WriteLine(Average(arr));

            double[] arr2 = { 10.0,20.0,30.0};
            Console.WriteLine(Average(arr2));
        }
        public static int Average(int[] arr)
        {
            int sum=0;
            for (int i = 0;i<arr.Length;i++)
            {
                sum = sum + arr[i];
            }
            return sum/arr.Length;
        }
        public static double Average(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum / arr.Length;
        }
    }
}
