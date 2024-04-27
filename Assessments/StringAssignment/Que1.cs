using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssignment
{
    //1.	WAP to split string into 2 tokens where string is “HELLO$WORLD”

    public class Que1
    {
        static void Main(string[] args)
        {
            string s = "HELLO$WORLD";
            string[] str = s.Split('$');

            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]+" ");
            }
        }
    }
}
