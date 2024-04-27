using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssignment
{
    //8.	Write a C# program to toggle case of each character of a string.
    public class Que8
    {
        static void Main(string[] args)
        {
            string s = "Hello World";

            string str=ToggleCase(s);

            Console.WriteLine($"After ToggleCase={str}");
        }
        static string ToggleCase(string s)
        {
            char[] ch=s.ToCharArray();
            string str = String.Empty;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >='a' && ch[i]<='z')
                {
                    ch[i] = (char)(ch[i] - 32);
                    str = str + ch[i];
                }else if(ch[i] >= 'A' && ch[i] <= 'Z')
                {
                    ch[i] = (char)(ch[i] + 32);
                    str = str + ch[i];
                }
                else
                {
                    str = str + ch[i];
                }
            }
            return str;

            
        }
    }
}
