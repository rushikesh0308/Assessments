﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.FundamentalAssignment
{
    public class ElectricityBill
    {
        static void Main(string[] args)
        {
            Console.Write("Enter units: ");
            int units = Convert.ToInt32(Console.ReadLine());
            double bill = 0;

            if (units <= 50)
            {
                bill = units * 0.50;
            }
            else if (units <= 150)
            {
                bill = (50 * 0.50) + ((units - 50) * 0.75);
            }
            else if (units <= 250)
            {
                bill = (50 * 0.50) + (100 * 0.75) + ((units - 150) * 1.20);
            }
            else
            {
                bill = (50 * 0.50) + (100 * 0.75) + (100 * 1.20) + ((units - 250) * 1.50);
            }

            // Adding a 20% surcharge to the bill
            bill += bill * 0.20;

            Console.WriteLine($"The total electricity bill is: {bill}");
        }
    }
}
