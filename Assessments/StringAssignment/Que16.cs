using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssignment
{
    //16.Write a C# program to check whether two strings are anagram or not?
    public class Que16
    {
        static void Main(string[] args)
        {
            string s1 = "listen";
            string s2 = "silent";

            if (CheckAnagram(s1,s2))
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }
        }
        static bool CheckAnagram(string s1, string s2)
        {
            s1=SortString(s1);

            s2=SortString(s2);

            return s1.Equals(s2);
        }
        static string SortString(string s)
        {
            char[] ch = s.ToCharArray();

            for(int i=0;i<ch.Length;i++)
            {
                for(int j=i+1;j<ch.Length;j++)
                {
                    if (ch[i] > ch[j])
                    {
                        char temp = ch[i];
                        ch[i] = ch[j];
                        ch[j] = temp;
                    }
                }
            }
            string str = String.Empty;

            for(int i = 0; i < ch.Length; i++)
            {
                str += ch[i];
            }
            return str;
        }
    }
}
