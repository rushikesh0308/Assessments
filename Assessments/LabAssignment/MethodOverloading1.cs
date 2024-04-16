using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LabAssignment
{
    public class MethodOverloading1
    {
        public void Area(int radius)
        {
            Console.WriteLine("Area of Circle:" + 3.14 * radius * radius);
        }
        public void Area(int b, int h)
        {
            Console.WriteLine("Area of Triangle:" + 0.5 * b * h);
        }
        public void Area(double l, double w)
        {
            Console.WriteLine("Area of Rectangle:" + l * w);
        }
        public void Area(double a)
        {
            Console.WriteLine("Area of Square:" + a * a);
        }
        static void Main(string[] args)
        {
            MethodOverloading1 obj = new MethodOverloading1();

            int choice;
            char ch;



            do
            {
                Console.WriteLine("1.Area of Rectangle\n2.Area of Triangle\n3.Area of Circle\n4.Area of Square");
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine("Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter length:");
                        double l = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter width:");
                        double w = Convert.ToDouble(Console.ReadLine());

                        obj.Area(l, w);
                        break;
                    case 2:
                        Console.WriteLine("Enter base:");
                        int b = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter height:");
                        int h = Convert.ToInt32(Console.ReadLine());

                        obj.Area(b, h);
                        break;

                    case 3:
                        Console.WriteLine("Enter radius:");
                        int r = Convert.ToInt32(Console.ReadLine());

                        obj.Area(r);
                        break;
                    case 4:
                        Console.WriteLine("Enter side of square:");
                        double a = Convert.ToDouble(Console.ReadLine());

                        obj.Area(a);
                        break;
                }
                Console.WriteLine("Continue(Y)/Stop(N)");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'Y' || ch == 'y');
        }
    }
}
