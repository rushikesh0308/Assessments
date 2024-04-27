using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.ArrayAssignment
{
    public class Que4
    {
        //4.	WAP to put even and odd elements of array in two separate arrays.
        static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4,5,6,7,8};

            PrintEvenOddArray(arr);
        }
        static void PrintEvenOddArray(int[] arr)
        {
            int[] evenArr= new int[arr.Length];
            int index1 = 0;
            int[] oddArr= new int[arr.Length];
            int index2 = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenArr[index1++] = arr[i];
                }
                if (arr[i] % 2 == 1)
                {
                    oddArr[index2++] = arr[i];
                }
            }

            Console.WriteLine("------Even Array------");
            for (int i = 0;i < evenArr.Length;i++)
            {
                if (evenArr[i] !=0)
                {
                    Console.Write(evenArr[i]+" ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("------Odd Array------");
            for (int i = 0; i < oddArr.Length; i++)
            {
                if (evenArr[i] != 0)
                {
                    Console.Write(oddArr[i] + " ");
                }
            }
        }
    }
}
