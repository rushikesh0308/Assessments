using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.MethodAssignment
{
    public class Student
    {
        protected int id;
        protected string name;
        protected int age;

        public Student()
        {
            this.id = 1;
            this.name = "Ravi";
            this.age = 21;
        }
        public Student(int id,string name,int age)
        {
            this.id=id;
            this.name = name;
            this.age = age;
        }
        public string DisplayData()
        {
            return $"Student id={GetId()},name={name},age={age}";
        }
        public int GetId()
        {
            return this.id;
        }
        public void SetCustomData(int id, string name, int age)
        { 
            this.id = id;
            this.name = name;
            this.age = age;
        }
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine(s1.DisplayData());

            Student s2= new Student(2,"Neha",21);
            Console.WriteLine(s2.DisplayData());

            Student s3 = new Student();
            s3.SetCustomData(3, "Omkar", 24);
            Console.WriteLine(s3.DisplayData());
        }
    }
}
