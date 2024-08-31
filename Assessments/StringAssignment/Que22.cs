using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssignment
{
    //22.	Create an array of 10 names sort in descending order
    public class Que22
    {
        static void Main()
        {
            // Create an array of 10 names.
            string[] names = { "Alice", "Bob", "Charlie", "David", "Eve", "Frank", "Grace", "Hannah", "Ivy", "Jack" };

            // Sort the array in descending order.
            Array.Sort(names, (name1, name2) => name2.CompareTo(name1));

            // Print the sorted array.
            Console.WriteLine("Names sorted in descending order:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
