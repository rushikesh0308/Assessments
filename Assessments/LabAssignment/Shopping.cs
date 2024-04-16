using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LabAssignment
{
    public class Shopping
    {
        private int pid;
        private string pname;
        private double price;
        private int quantity;
        private double totalPrice;

        public Shopping()
        {

        }
        public Shopping(int pid, string pname, double price, int quantity)
        {
            this.pid = pid;
            this.pname = pname;
            this.price = price;
            this.quantity = quantity;
        }

        public void AcceptValues()
        {
            Console.WriteLine("Enter product id:");
            pid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter product name:");
            pname = Console.ReadLine();

            Console.WriteLine("Enter price:");
            price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter quantity:");
            quantity = Convert.ToInt32(Console.ReadLine());
        }
        public void CalculateTotalPrice()
        {
            if (quantity > 0)
            {
                totalPrice = price * quantity;
            }
            else
            {
                Console.WriteLine("Quantity must be grater than zero!");
            }
        }

        public void DisplayShoppingDetails()
        {
            Console.WriteLine("Product Id:" + pid);
            Console.WriteLine("Product Name:" + pname);
            Console.WriteLine("Total Quantity:" + quantity);
            Console.WriteLine("Amount to pay:" + totalPrice);
        }
    }
}
