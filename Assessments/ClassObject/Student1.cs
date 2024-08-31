using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.ClassObject
{
    public class Student1
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Subject1Marks { get; set; }
        public int Subject2Marks { get; set; }
        public int Subject3Marks { get; set; }

        public Student1(int rollNo, string name, int subject1Marks, int subject2Marks, int subject3Marks)
        {
            RollNo = rollNo;
            Name = name;
            Subject1Marks = subject1Marks;
            Subject2Marks = subject2Marks;
            Subject3Marks = subject3Marks;
        }

        public int TotalMarks()
        {
            return Subject1Marks + Subject2Marks + Subject3Marks;
        }

        public double CalculatePercentage()
        {
            return (double)TotalMarks() / 3;
        }

        public override string ToString()
        {
            return $"Roll No: {RollNo}\nName: {Name}\nTotal Marks: {TotalMarks()}\nPercentage: {CalculatePercentage():F2}%";
        }
    }
}
