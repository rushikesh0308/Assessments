using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LabAssignment
{
    public class SearchElementArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int[] arr = new int[Convert.ToInt32(Console.ReadLine())];

            Console.WriteLine("Enter values:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter element you want to search:");
            int num=Convert.ToInt32(Console.ReadLine());

            bool result=SearchElement(arr, num);
            if(result)
            {
                Console.WriteLine("Element Found!");
            }else
            {
                Console.WriteLine("Element not Found!");
            }

        }
        static bool SearchElement(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (num == arr[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
