using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LabAssignment
{
    public class StudentDemo
    {

        static void Main(string[] args)
        {

            Student1 s1 = new Student1();
            s1.AcceptValue(101, "Tushar", 65, 86, 90);
            s1.CalculatePercentage();
            Console.WriteLine(s1.Display());

            Student1 s2 = new Student1();
            s2.AcceptUserValues();
            s2.CalculatePercentage();
            Console.WriteLine(s2.Display());
        }

    }
}
