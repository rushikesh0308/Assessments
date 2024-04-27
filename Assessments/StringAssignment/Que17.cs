using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssignment
{
    //17.Write a C# program to reverse a given string with preserving the position of spaces
    public class Que17
    {
        static void Main(string[] args)
        {
            string s = "I am learning C#";//# Cg ninraelm aI
            ReverseString(s);
        }
        static void ReverseString(string s)
        {
            char[] ch=s.ToCharArray();

            int i =0, j = ch.Length - 1;

            while(i<j)
            {
                if (ch[i] == ' ')
                {
                    i++;
                }
                else if (ch[j]==' ')
                {
                    j--;
                }
                else
                {
                    char temp = ch[i];
                    ch[i] = ch[j];
                    ch[j] = temp;
                    i++;
                    j--;
                }
            }
            string str=String.Empty;

            for(int k=0;k<ch.Length;k++)
            {
                str = str + ch[k];
            }
            Console.WriteLine(str);
        }
    }
}
