using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.ArrayAssignment
{
    public class Que1
    {
        //1.	WAP to search for a given number in an array and accordingly print the index if exists
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array:");
            int[] arr = new int[Convert.ToInt32(Console.ReadLine())];

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter number you want to find:");
            int num=Convert.ToInt32(Console.ReadLine());

            if (!SearchElement(arr,num))
            {
                Console.WriteLine("Element not found!");
            }

        }
        static bool SearchElement(int[] arr,int num)
        {
            bool flag=false;

            for (int i = 0;i < arr.Length;i++)
            {
                if (num == arr[i])
                {
                    flag = true;
                    Console.WriteLine($"Element found at index={i}");
                    break;
                }
            }
            return flag;
        }
    }
}
