using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LabAssignment
{
    public class StaticKeyword
    {
        private static int id = 1;

        public static int GetId()
        {
            return id;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(id);

            Console.WriteLine(GetId());
        }
    }
}
