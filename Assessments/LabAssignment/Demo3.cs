using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LabAssignment
{
    public interface IDemo1
    {
        static int a = 10;
    }
    public abstract class Demo2
    {
        public static int b = 20;
    }
    public class Demo3 : Demo2, IDemo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IDemo1.a + Demo2.b);
        }
    }
}
