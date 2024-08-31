using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.ClassObject
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Product ID: {Id}\nName: {Name}\nPrice: {Price:C}";
        }
        public void ApplyDiscount(decimal discountPercentage)
        {
            decimal discountAmount = (discountPercentage / 100) * Price;
            Price -= discountAmount;
            Console.WriteLine($"Actual Price: {Price + discountAmount:C}\nDiscounted Price: {Price:C}");
        }
    }
}
