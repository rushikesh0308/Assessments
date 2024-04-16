using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LabAssignment
{
    public class Student1
    {
        private int id;
        private string name;
        private int m1, m2, m3;
        private double per;

        public Student1()
        {

        }
        public Student1(int id, string name, int m1, int m2, int m3)
        {
            this.id = id;
            this.name = name;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }

        public void CalculatePercentage()
        {
            double total = m1 + m2 + m3;
            per = total * 100 / 300;
        }

        public string Display()
        {
            return $"Student: id={id},name={name},Percentage={per}";
        }

        public void AcceptValue(int id, string name, int m1, int m2, int m3)
        {
            this.id = id;
            this.name = name;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }

        public void AcceptUserValues()
        {
            Console.WriteLine("Enter student id:");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter student name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter marks of subject1:");
            m1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks of subject2:");
            m2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks of subject3:");
            m3 = Convert.ToInt32(Console.ReadLine());
        }

    }
}
