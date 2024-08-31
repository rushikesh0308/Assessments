using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.ClassObject
{
    public class Student
    {
        public int RollNo { get; set; } = 0;
        public string Name { get; set; } = "";
        public double Percentage { get; set; } = 0;

        public Student(int rollNo, string name, double percentage)
        {
            RollNo = rollNo;
            Name = name;
            Percentage = percentage;
        }

        public override string ToString()
        {
            return $"Roll No: {RollNo}\nName: {Name}\nPercentage: {Percentage}%";
        }
    }
}
