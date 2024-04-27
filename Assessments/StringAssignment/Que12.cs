using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssignment
{
    //12.Write a C# program to find highest frequency character in a string.
    public class Que12
    {
        static void Main(string[] args)
        {
            string s = "Hello World";
            HighestFrequency(s);
        }
        static void HighestFrequency(string s)
        {
            int ct,maxct=0;
            
            bool flag;
            char[] ch = s.ToCharArray();
            char c = ch[0];
            for (int i=0;i<ch.Length;i++)
            {
                ct = 1;
                flag = true;
                for(int j=i-1;j>=0;j--)
                {
                    if (ch[j] == ch[i])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    for(int k=i+1;k<ch.Length;k++)
                    {
                        if (ch[k] == ch[i])
                        {
                            ct++;
                        }
                    }
                    if(ct >= maxct)
                    {
                        maxct = ct;
                        c= ch[i];
                    }
                }
            }
            Console.WriteLine($"Highest Frequency Character={c} times {maxct}");
        }
    }
}
