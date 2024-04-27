using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.MethodAssignment
{
    public  class NumberCube
    {
        protected int num;
        public NumberCube() { }

        public NumberCube(int num)
        {
            this.num = num;
        }
        public void FindCube()
        {
            Console.WriteLine($"Cube is={num * num * num}");
        }
        public void FindCube(int num)
        {
            Console.WriteLine($"Cube is={num * num * num}");
        }
        public int CalculateCube()
        {
            return (num * num * num);
        }
        public double CalculateCube(int num)
        {
            return (num * num* num);
        }
        static void Main(string[] args)
        {
            NumberCube cube = new NumberCube(5);
            cube.FindCube();
            cube.FindCube(5);

            Console.WriteLine(cube.CalculateCube());
            Console.WriteLine(cube.CalculateCube(5));
        }
    }
}
