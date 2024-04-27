using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.MethodAssignment
{
    public class Square
    {
        protected int side;
        public Square() 
        { }
        public Square(int side)
        {
            this.side = side;
        }
        public void FindSquare()
        {
            Console.WriteLine($"Square is={side*side}");
        }
        public void FindSquare(int side)
        {
            Console.WriteLine($"Square is={side * side}");
        }
        public int CalculateSquare()
        {
            return (side * side);
        }
        public double CalculateSquare(int side)
        {
            return (side * side);
        }
        static void Main(string[] args)
        {
            Square square = new Square(4);

            square.FindSquare();
           square.FindSquare(4);

            Console.WriteLine(square.CalculateSquare());
            Console.WriteLine(square.CalculateSquare(4));
        }
    }
}
