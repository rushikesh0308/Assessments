using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.ClassObject
{
    public class Employee
    {
        private static int totalEmployees = 0;
        private const double PT = 200;
        double grossSal;

        public int Id { get; set; }
        public string Name { get; set; }
        public double BasicSalary { get; set; }
        public double HRA { get; set; }
        public double TA { get; set; }
        public double PF { get; set; }

        public Employee(int id, string name, double basicSalary)
        {
            Id = id;
            Name = name;
            BasicSalary = basicSalary;
            HRA = 0.4 * BasicSalary;
            TA = 0.2 * BasicSalary;
            PF = 0.12 * BasicSalary;
            totalEmployees++;
        }

        public double GrossSalary()
        {
            grossSal = BasicSalary + HRA + TA - PF - PT;
            return grossSal;
        }

        public static void DisplayTotalEmployees()
        {
            Console.WriteLine($"Total number of employees: {totalEmployees}");
        }

        public override string ToString()
        {
            return $"Employee ID: {Id}\nName: {Name}\nGross Salary: {grossSal}";
        }
    }
}
