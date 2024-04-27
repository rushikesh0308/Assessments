using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssignment
{
    //15.Write a C# program to find the duplicate words and their number of occurrences in a string
    public class Que15
    {
        static void Main(string[] args)
        {
            string s = "for the first time he came first in the competition";

            FindDuplicateWords(s);
        }
        static void FindDuplicateWords(string s)
        {
            string[] str = s.Split(' ');

            int ct;
            bool flag;
            for(int i=0;i<str.Length;i++)
            {
                flag = true;
                ct = 1;

                for(int k=i-1;k>=0;k--)
                {
                    if (str[i].Equals(str[k]))
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    for (int j = i + 1; j <str.Length; j++)
                    {
                        if (str[i].Equals(str[j]))
                        {
                            ct++;
                        }
                    }
                    if (ct > 1)
                    {
                        Console.WriteLine($"{str[i]}={ct} times");
                    }
                }
            }
        }
    }
}
