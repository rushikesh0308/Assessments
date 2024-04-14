using Assessments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments
{
    class A
    {
        private static int a1 = 10;
        protected static int a2 = 20;
        public static int a3 = 30;
        internal static int a4 = 40;
    }

    class D1: A {

        static void Main(string[] args)
        {
           // Console.WriteLine(A.a1);
           Console.WriteLine(A.a2);
             Console.WriteLine(A.a3);
            Console.WriteLine(A.a4);
        }
    }

    class B {
        static void Main(string[] args)
        {
            // Console.WriteLine(A.a1);
           // Console.WriteLine(A.a2);
            Console.WriteLine(A.a3);
            Console.WriteLine(A.a4);
        }
    }
}
namespace Second
{ 
    class C {
        static void Main(string[] args)
        {
           // Console.WriteLine(A.a2);
            Console.WriteLine(Assessments.A.a3);
            Console.WriteLine(Assessments.A.a4);

        }

    }

    class D2:Assessments.A {
        static void Main(string[] args)
        {
            Console.WriteLine(A.a2);
            Console.WriteLine(A.a3);
            Console.WriteLine(A.a4);
        }
    }
    class D {
        static void Main(string[] args)
        {
           // Console.WriteLine(A.a2);
            Console.WriteLine(Assessments.A.a3);
            Console.WriteLine(Assessments.A.a4);
        }
    }

}
