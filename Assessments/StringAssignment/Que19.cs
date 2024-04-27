using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssignment
{
    public class Que19
    {
        //19.How do you swap two string variables without using third or temp variable in C#
        static void Main(string[] args)
        {
            Console.WriteLine("First String:");
            string s1=Console.ReadLine();//Hello-->5

            Console.WriteLine("Second String:");
            string s2=Console.ReadLine();//World-->5

            //(s1, s2) = (s2, s1);

            s1 = s1 + s2;//--->10

            s2=s1.Substring(0,s1.Length-s2.Length);//Hello

            s1 = s1.Substring(s2.Length);//World

            Console.WriteLine("First String:"+s1);
            Console.WriteLine("Second String:"+s2);


        }
    }
}
