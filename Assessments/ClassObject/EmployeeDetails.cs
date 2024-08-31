using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.ClassObject
{
    public class EmployeeDetails
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "om", 100000);
            Console.WriteLine(e1);
            Console.WriteLine($"Gross Salary is : {e1.GrossSalary}");
            Employee.DisplayTotalEmployees();
        }
    }
}
