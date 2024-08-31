using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.ClassObject
{
    public class ProductDetails
    {
        static void Main(string[] args)
        {
            Product p1 = new Product() { Id = 1, Name = "Mouse", Price = 299 };
            p1.ApplyDiscount(10);
            Console.WriteLine(p1);
        }
    }
}
