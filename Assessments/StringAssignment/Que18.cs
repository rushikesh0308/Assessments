using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssignment
{
    //18.WAP to find longest word in the given sentence
    public class Que18
    {
        static void Main(string[] args)
        {
            string s = "I am learning framework of dotnet";

            LongestWord(s);
        }
        static void LongestWord(string s)
        {
            string[] str= s.Split(' ');

            string s1=String.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length>s1.Length)
                {
                    s1 = str[i];
                }
            }
            Console.WriteLine($"Longest Word={s1}");
        }
    }
}
