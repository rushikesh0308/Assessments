using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssignment
{
    //9.Write a C# program to count total number of vowels and consonants in a string.
    public class Que9
    {
         static void Main(string[] args)
        {
            string s = "Hello World12";
            CountVowelsConsonents(s);
        }
        static void CountVowelsConsonents(string s)
        {
            char[] ch=s.ToCharArray();

            int vcount = 0, ccount = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if ((ch[i]>='a' && ch[i]<='z') || (ch[i]>='A' && ch[i]<='Z'))
                {
                    if (ch[i] == 'a' || ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u' ||
                    ch[i] == 'A' || ch[i] == 'E' || ch[i] == 'I' || ch[i] == 'O' || ch[i] == 'U')
                    {
                        vcount++;
                    }
                    else
                    {
                        ccount++;
                    }
                }
            }
            Console.WriteLine($"Vowel Count={vcount}");
            Console.WriteLine($"Consonant Count={ccount}");
        }
    }
}
