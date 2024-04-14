using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments
{
    public class Student
    {
        private int rollno;
        private string name;

        public Student()
        {
            rollno = 1;
            name = "Rohit";
        }
        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }

        public string Display()
        {
            return $"rollno={rollno},name={name}";
        }
    }
}
