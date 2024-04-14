using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments
{
    public class Employee
    {
        private int empid;
        private string empname;
        private double bs, hra, pf,gross;

        public void Assign()
        {
            empid = 1;
            empname = "Rohit";
            bs = 5000;
            hra = 1500;
            pf = 500;
        }

        public void Accept(int id, string name, double b, double h, double p)
        { 
            empid=id;
            empname = name;
            bs = b;
            hra = h;
            pf = p;
        }
        public void CalculateSalary()
        {
            gross = (bs + hra) - pf;
        }

        public string Display()
        {
            return $"empid={empid}, empname={empname},salary={gross}";
        }
    }
}
