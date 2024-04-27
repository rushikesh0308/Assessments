using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.ArrayAssignment
{
    //7.	WAP to print all unique elements in the array.
    public class Que7
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 2, 2, 2, 3, 4, 5, 5 };
            FindUnique(arr);
        }
        static void FindUnique(int[] arr)
        {
            int ct;
            bool flag;
            for (int i = 0; i < arr.Length; i++)
            {
                ct = 1;
                flag = true;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (arr[i] == arr[k])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            ct++;
                        }
                    }
                    if (ct == 1)
                    {
                        Console.WriteLine(arr[i] + "-->" + ct);
                    }
                }
            }
        }
    }
}
